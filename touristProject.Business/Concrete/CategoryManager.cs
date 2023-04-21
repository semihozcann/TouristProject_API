using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Business.Abstract;
using touristProject.Business.Constants;
using touristProject.Core.Utilities.Business;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Core.Utilities.Result.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Categories;

namespace touristProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto)
        {
            Task<IResult> result = BusinessRules.Run(CategoryNameAlreadyExist(categoryAddDto.Name));
            if (result != null)
            {
                return result.Result;
            }

            var category = _mapper.Map<Category>(categoryAddDto);
            await _categoryRepository.AddAsync(category);
            await _categoryRepository.SaveAsync();
            return new SuccessResult(Messages.CategoryAdded);
        }

        public async Task<IResult> DeleteAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                var deletedCategory = await _categoryRepository.DeleteAsync(category);
                await _categoryRepository.SaveAsync();
                return new SuccessResult(Messages.CategoryDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CategoryNotFound);
            }
        }

        public async Task<IDataResult<List<Category>>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories != null)
            {
                return new SuccessDataResult<List<Category>>(categories, Messages.CategoryListed);
            }
            else
            {
                return new ErrorDataResult<List<Category>>(Messages.CategoryNotFound);
            }
        }

        public async Task<IDataResult<Category>> GetByIdAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                return new SuccessDataResult<Category>(category, Messages.CategoryGeted);
            }
            else
            {
                return new ErrorDataResult<Category>(Messages.CategoryNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var oldCategory = await _categoryRepository.GetAsync(c => c.Id == categoryUpdateDto.Id);
            var category = _mapper.Map<CategoryUpdateDto, Category>(categoryUpdateDto, oldCategory);
            var updatedCategory = await _categoryRepository.UpdateAsync(category);
            await _categoryRepository.SaveAsync();

            return new SuccessResult(Messages.CategoryUpdated);
        }





        #region BusinessRules

        public async Task<IResult> CategoryNameAlreadyExist(string categoryName)
        {
            //Burada aynı isimde başka bir örnek eklenmesini engellemek amacıyla bir örnek kural yazılmıştır.
            var category = await _categoryRepository.GetAllAsync(c => c.Name == categoryName);
            var result = category.Any();
            if (result)
            {
                return new ErrorResult(Messages.CategoryNameAlreadyExist);
            }
            return new SuccessResult();
        }

        #endregion
    }
}
