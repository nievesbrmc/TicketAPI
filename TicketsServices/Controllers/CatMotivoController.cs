using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketsServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatMotivoController : ControllerBase
    {
        private readonly IcatMotivoBLL bl;

        public CatMotivoController(IcatMotivoBLL _bl)
        {
            bl = _bl;
        }

        // GET: api/<CatMotivoController>
        [HttpGet]
        public List<catMotivos> Get()
        {
           return bl.Select(null);
           // return new string[] { "value1", "value2" };
        }

        // GET api/<CatMotivoController>/5
        [HttpGet("{id}")]
        public catMotivos Get(int id)
        {
            return bl.Select(id).FirstOrDefault();
        }

        // POST api/<CatMotivoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CatMotivoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatMotivoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
