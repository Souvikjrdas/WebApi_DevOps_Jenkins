using Microsoft.AspNetCore.Mvc;
using PracticeWebAPIs.Models;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<HomeController>
        [HttpGet]
        [Route("getAll")]
        public ActionResult<string> Get()
        {
            return Ok(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Id value is {id}";
        }

        // POST api/<HomeController>
        [HttpPost("[action]/{id:int}/{name}")]
        public IActionResult Add([FromRoute] Items item , [FromRoute] Items item1)
        {
            LinkedList<string> list = new LinkedList<string>();
            return Ok(); 
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
