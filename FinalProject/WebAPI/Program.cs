using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Autofac;
using Business.DependencyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;

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
// icinde data tutmuyorsak singleton kullan | yani basket varsa o zaman hepsini her musteri de kullanir 
// Autofact, Ninject, CastleWindsor, StructureMap, LightInject, Dryinject -> IoC container gorevi yapiyordu build ediyordu  
// AOP kullanacagiz ileri ki zamanlarda kod karmasikligi olmasin sunu yaptim mi olmasin diye
// Autofact bunu gayet guzel karisliyor 
// builder.Services.AddSingleton<IProductService,ProductManager>(); // sen burada bir service gorursen o service somut nesneyi referance olarak tut, arka planda tutar
// builder.Services.AddSingleton<IProductDal, EfProductDal>();
// addScoped 
// addTransiet
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapControllers();
app.Run();

