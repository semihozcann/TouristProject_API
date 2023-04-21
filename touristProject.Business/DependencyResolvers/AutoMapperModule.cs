using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Utilities.IoC;
using touristProject.DataAccess.AutoMapper;

namespace touristProject.Business.DependencyResolvers
{
    public class AutoMapperModule : ICoreModule
    {
        //AutoMapper kütüphanesinin API içerinde Program.cs içerisinde yazılması gereken comfigurasyon kodudur.
        //Comfigurasyon ICoreModule interfacesi üzerinden Program.cs içerisine eklenmiştir.
        //Bu kodların çalışması için Program.cs içerisinde AddDependencyResolvers metodu içerisinde new'lenerek AutoMapperModule classı eklenmelidir.
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                typeof(CategoryProfile),
                typeof(NutrientProfile)

                );
        }
    }
}
