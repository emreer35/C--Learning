
using System;
using Business.Constans;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac;

// JWT icin 
public class SecuredOperation : MethodInterception
{
    private string[] _roles;
    private IHttpContextAccessor _httpContextAccessor; // jwt yi gondererek istek atiyoruz her istek icin bunu olusturururz

    public SecuredOperation(string roles)
    {
        _roles = roles.Split(','); // yazdigimiz stringleri , ile ayirarark array haline getiriyor  
        _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>(); // controller business i cagiriyor business dal i cagiriyor
        // bu zincirin icersiinde aspect yok 
        // service tool bir injection altyapimizi aynen okuyabilmesi icin bir aractir 

    }

    protected override void OnBefore(IInvocation invocation)
    {
        var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
        foreach (var role in _roles)
        {
            if (roleClaims.Contains(role))
            {
                return;
            }
        }
        throw new Exception(Messages.AuthorizationDenied);
    }
}
