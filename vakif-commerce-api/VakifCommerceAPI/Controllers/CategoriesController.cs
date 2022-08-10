using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VakifCommerce.BLL.Abstract;

namespace VakifCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();

            return Ok(result);
        }
    }
}
