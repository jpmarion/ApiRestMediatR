using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRestMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<SocioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SocioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SocioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SocioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SocioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
