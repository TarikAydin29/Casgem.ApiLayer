using Casgem.BLL.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet]
        public IActionResult CustomerList()
        {
            var v = customerService.TGetList();
            return Ok(v);
        }
        [HttpPost]
        public IActionResult Add(Customer c)
        {
            customerService.TInsert(c);
            return Ok($"{c.Name} Eklendi.");
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            Customer c = customerService.TGetById(id);
            customerService.TDelete(c);
            return Ok($"{c.Name} Silindi.");
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Customer c = customerService.TGetById(id);
            if (c == null)
                return NotFound("Müşteri Bulunamadı");

            return Ok(c);
        }
        [HttpPut]
        public IActionResult Update(Customer c)
        {
            customerService.TUpdate(c);
            Customer customer = c;
            return Ok($"{c.Name} Güncellendi.");
        }
    }
}
