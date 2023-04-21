using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Categories;

namespace touristProject.Business.Abstract
{
    public interface ICategoryService
    {

        Task<IDataResult<Category>> GetByIdAsync(int categoryId);
        Task<IDataResult<List<Category>>> GetAllAsync();
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto);
        Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IResult> DeleteAsync(int categoryId);

    }
}
