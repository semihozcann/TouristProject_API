using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Business.Abstract;
using touristProject.Business.Concrete;
using touristProject.Core.Utilities.Interceptors;
using touristProject.Core.Utilities.Security.JWT;
using touristProject.DataAccess.Abstract;
using touristProject.DataAccess.Concrete.EntityFramework;
using touristProject.DataAccess.Concrete.EntityFramework.Context;

namespace touristProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<TouristProjectContext>().As<DbContext>().SingleInstance();

            builder.RegisterType<EfUserRepository>().As<IUserRepository>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();


            builder.RegisterType<EfNutrientRepository>().As<INutrientRepository>();
            builder.RegisterType<NutrientManager>().As<INutrientService>();

            //builder.RegisterType<EfNutrientImageRepository>().As<INutrientImageRepository>();
            //builder.RegisterType<NutrientImageManager>().As<INutrientImageService>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
