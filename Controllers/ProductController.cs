using Ders2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ders2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products;

        public ProductController()
        {
            if (products == null)
            {
                products = ProductService.GetProducts();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);

            return StatusCode(StatusCodes.Status201Created, product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                products.Remove(product);
                return Ok(product);
            }
        }
    }
}
