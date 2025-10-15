using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC;

public static class ServiceTool
{ 
    // bu kod blogu autofacta ya da web api de olusturdugumuz injection lari yapmamizi sagliyor 
    // artik biz herhangi bir interface in karsiligini service deki karsiligini bu tool vasitasiyla alabiliriz 
    public static IServiceProvider ServiceProvider { get; private set; }

    public static IServiceCollection Create(IServiceCollection services) // .net in servicelerini al 
    {
        ServiceProvider = services.BuildServiceProvider(); // onlari build et 
        return services;
    }
}