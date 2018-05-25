using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Movies.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>() { 
                new Movie { Id = 1, Name = "Jurassic Park", Price = 1.5},
                new Movie { Id = 2, Name = "Avtar", Price = 1.75},
                new Movie { Id = 3, Name = "Moana", Price = 2.5}
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
