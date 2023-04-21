using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Business.Abstract;
using touristProject.Business.Constants;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Core.Utilities.Result.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Nutrients;

namespace touristProject.Business.Concrete
{
    public class NutrientManager : INutrientService
    {
        private readonly INutrientRepository _nutrientRepository;
        private readonly IMapper _mapper;

        public NutrientManager(INutrientRepository nutrientRepository, IMapper mapper)
        {
            _nutrientRepository = nutrientRepository;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(NutrientAddDto nutrientAddDto)
        {
            var nutrient = _mapper.Map<Nutrient>(nutrientAddDto);
            var result = await _nutrientRepository.AddAsync(nutrient);
            await _nutrientRepository.SaveAsync();
            return new SuccessResult(Messages.NutrientAdded);
        }

        public async Task<IResult> DeleteAsync(int nutrientId)
        {
            var nutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientId);
            if (nutrient != null)
            {
                await _nutrientRepository.DeleteAsync(nutrient);
                await _nutrientRepository.SaveAsync();
                return new SuccessResult(Messages.NutrientDeleted);
            }
            return new ErrorResult(Messages.NutrientNotFound);
        }

        public async Task<IDataResult<List<Nutrient>>> GetAllAsync()
        {
            var nutrients = await _nutrientRepository.GetAllAsync();
            if (nutrients != null)
            {
                return new SuccessDataResult<List<Nutrient>>(nutrients, Messages.NutrientListed);
            }
            return new ErrorDataResult<List<Nutrient>>(Messages.NutrientNotFound);
        }

        public async Task<IDataResult<Nutrient>> GetByIdAsync(int nutrientId)
        {
            var nutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientId);
            if(nutrient != null)
            {
                return new SuccessDataResult<Nutrient>(nutrient, Messages.NutrientGeted);
            }
            return new ErrorDataResult<Nutrient>(Messages.NutrientNotFound);
        }

        public async Task<IResult> UpdateAsync(NutrientUpdateDto nutrientUpdateDto)
        {
            var oldNutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientUpdateDto.Id);
            var nutrient = _mapper.Map<NutrientUpdateDto, Nutrient>(nutrientUpdateDto, oldNutrient);
            if (nutrient != null)
            {
                await _nutrientRepository.UpdateAsync(nutrient);
                return new SuccessDataResult<Nutrient>(nutrient, Messages.NutrientUpdated);
            }
            return new ErrorDataResult<Nutrient>(Messages.NutrientNotFound);
        }
    }
}
