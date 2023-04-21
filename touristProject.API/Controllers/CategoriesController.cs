using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using touristProject.Business.Abstract;
using touristProject.Entities.Concrete;
using touristProject.Entities.DTOs.Categories;

namespace touristProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var result = await _categoryService.GetByIdAsync(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var result = await _categoryService.AddAsync(categoryAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var result = await _categoryService.UpdateAsync(categoryUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _categoryService.DeleteAsync(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
