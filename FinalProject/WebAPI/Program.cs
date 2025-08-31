using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();
// icinde data tutmuyorsak singleton kullan | yani basket varsa o zaman hepsini her musteri de kullanir 
// Autofact, Ninject, CastleWindsor, StructureMap, LightInject, Dryinject -> IoC container gorevi yapiyordu build ediyordu  
// AOP kullanacagiz ileri ki zamanlarda kod karmasikligi olmasin sunu yaptim mi olmasin diye
// Autofact bunu gayet guzel karisliyor 
builder.Services.AddSingleton<IProductService,ProductManager>(); // sen burada bir service gorursen o service somut nesneyi referance olarak tut, arka planda tutar
builder.Services.AddSingleton<IProductDal, EfProductDal>();
// addScoped 
// addTransiet
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
