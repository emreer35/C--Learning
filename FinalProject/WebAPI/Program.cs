using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Autofac;
using Business.DependencyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Core.Utilities.Security.Encryption;
using Core.Utilities.IoC;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(container =>
{
    container.RegisterModule(new AutofacBusinessModule());
});

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor(); 
// icinde data tutmuyorsak singleton kullan | yani basket varsa o zaman hepsini her musteri de kullanir 
// Autofact, Ninject, CastleWindsor, StructureMap, LightInject, Dryinject -> IoC container gorevi yapiyordu build ediyordu  
// AOP kullanacagiz ileri ki zamanlarda kod karmasikligi olmasin sunu yaptim mi olmasin diye
// Autofact bunu gayet guzel karisliyor 
// builder.Services.AddSingleton<IProductService,ProductManager>(); // sen burada bir service gorursen o service somut nesneyi referance olarak tut, arka planda tutar
// builder.Services.AddSingleton<IProductDal, EfProductDal>();
// addScoped 
// addTransiet
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters=new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
var app = builder.Build();
ServiceTool.Create(builder.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();
app.Run();

