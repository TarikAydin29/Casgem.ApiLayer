using Casgem.BLL.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [Route("ProductList")]
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = productService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            productService.TInsert(product);
            return Ok();

        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var v = productService.TGetById(id);
            productService.TDelete(v);
            return Ok(v);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Product p = productService.TGetById(id);
            if (p == null)
                return NotFound("Ürün Bulunamadı");

            return Ok(p);
        }
        [HttpPut]
        public IActionResult Update(Product p)
        {
            productService.TUpdate(p);
            Product updated = p;
            return Ok($"{p.Name} Güncellendi.");
        }
        [Route("ProductListWithCategory")]
        [HttpGet]
        public IActionResult ProductListWithCategory()
        {
            var values = productService.TGetProductsWithCategories();
            return Ok(values);
        }
    }
}
