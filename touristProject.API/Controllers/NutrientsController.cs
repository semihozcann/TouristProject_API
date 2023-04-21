using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using touristProject.Business.Abstract;
using touristProject.Entities.DTOs.Nutrients;

namespace touristProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutrientsController : ControllerBase
    {
        private readonly INutrientService _nutrientService;

        public NutrientsController(INutrientService nutrientService)
        {
            _nutrientService = nutrientService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _nutrientService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var result = await _nutrientService.GetByIdAsync(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(NutrientAddDto nutrientAddDto)
        {
            var result = await _nutrientService.AddAsync(nutrientAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(NutrientUpdateDto nutrientUpdateDto)
        {
            var result = await _nutrientService.UpdateAsync(nutrientUpdateDto);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _nutrientService.DeleteAsync(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
