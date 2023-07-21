using Casgem.BLL.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            List<Category> categories = categoryService.TGetList();
            if (categories == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(categories);
            }
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            //Category c = new Category()
            //{
            //    Name = category
            //};
            categoryService.TInsert(c);
            return Ok(c);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            if (category.CategoryID < 1)
            {
                return BadRequest();
            }
            categoryService.TUpdate(category);
            return Ok(category);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCategory(int id)
        {
            var v = categoryService.TGetById(id);
            categoryService.TDelete(v);
            return Ok();
        }


        [HttpGet("{id:int}")]
        public IActionResult GetCategory(int id)
        {
            return Ok(categoryService.TGetById(id));
        }
    }
}
