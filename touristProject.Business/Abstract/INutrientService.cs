using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Categories;
using touristProject.Entities.DTOs.Nutrients;

namespace touristProject.Business.Abstract
{
    public interface INutrientService
    {
        Task<IDataResult<Nutrient>> GetByIdAsync(int nutrientId);
        Task<IDataResult<List<Nutrient>>> GetAllAsync();
        Task<IResult> AddAsync(NutrientAddDto nutrientAddDto);
        Task<IResult> UpdateAsync(NutrientUpdateDto nutrientUpdateDto);
        Task<IResult> DeleteAsync(int nutrientId);
    }
}
