using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Nutrients;

namespace touristProject.DataAccess.AutoMapper
{
    public class NutrientProfile : Profile
    {
        public NutrientProfile()
        {
            CreateMap<NutrientAddDto, Nutrient>();
            CreateMap<NutrientUpdateDto, Nutrient>();
            CreateMap<Nutrient, NutrientUpdateDto>();
        }
    }
}
