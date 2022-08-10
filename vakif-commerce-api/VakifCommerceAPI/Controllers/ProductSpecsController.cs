using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VakifCommerce.BLL.Abstract;

namespace VakifCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSpecsController : ControllerBase
    {
        private readonly IProductSpecsService _productSpecsService;

        public ProductSpecsController(IProductSpecsService productSpecsService)
        {
            _productSpecsService = productSpecsService;
        }

        [HttpGet("GetProductSpecs")]
        public IActionResult GetList()
        {
            var result = _productSpecsService.GetList();

            return Ok(result);
        }
    }
}
