using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderProcessing.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productrepository;
        public ProductController(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllCustomers()
        {
            return await _productrepository.GetAllProducts();
        }
    }
}
