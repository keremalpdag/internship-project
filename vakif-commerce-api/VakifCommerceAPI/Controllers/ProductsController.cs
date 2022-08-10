using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VakifCommerce.BLL.Abstract;

namespace VakifCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProducts")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();

            return Ok(result);
        }
        [HttpGet("GetListByCategory")]
        public IActionResult GetListByCategory([FromQuery] int id)
        {
            var result = _productService.GetListByCategory(id);

            return Ok(result);
        }
    }
}
