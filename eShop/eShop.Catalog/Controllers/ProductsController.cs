using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>() { 
                new Product { Id = 1, Name = "Apple", Price = 1.5},
                new Product { Id = 2, Name = "Mango", Price = 1.75},
                new Product { Id = 3, Name = "Jackfruit", Price = 2.5},
                new Product { Id = 4, Name = "Grapes", Price = 4.5}
             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
