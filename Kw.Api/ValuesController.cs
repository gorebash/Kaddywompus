using Kw.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kw.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            // return proper User models from shared library for proper deserialize.
            var user = new User
            {
                Id = 1,
                Name = "Brent Gore"
            };

            return new List<User> { 
                user, 
                new User
                {
                    Id = 2,
                    Name = "Panther",
                },
                new User
                {
                    Id = 2,
                    Name = "Monkey",
                },
                new User
                {
                    Id = 2,
                    Name = "Fox",
                },
                new User
                {
                    Id = 2,
                    Name = "Zebra",
                },
                new User
                {
                    Id = 2,
                    Name = "Moose",
                },
            };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
