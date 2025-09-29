using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
        builder.RegisterType<EfProductDal>().As<IProductDal>().InstancePerLifetimeScope();

        builder.RegisterType<CategoryManager>().As<ICategoryService>().InstancePerLifetimeScope();
        builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().InstancePerLifetimeScope();


        var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
    }
}
