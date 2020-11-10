using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;
using SensorREST.DButil;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        private Manager mgr = new Manager();
        List<SensorData> liste = new List<SensorData>()
        {
            new SensorData(1, "test", 10.4, 50)
        };

        // GET: api/<SensorsController>
        [HttpGet]
        public IEnumerable<SensorData> Get()
        {
            return liste;
        }

        // GET api/<SensorsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200)] //når der er en CD med substring
        [ProducesResponseType(404)] //når substring ikke matcher nogen artist 
        public IActionResult Get(int id)
        {
            if (liste.Exists(p => p.Id == id))
            {
                return Ok(liste.Find(p => p.Id == id));
            }

            return NotFound($"Sensor med id {id} findes ikke");
           
        }

        // POST api/<SensorsController>
        [HttpPost]
        public void Post([FromBody] SensorData value)
        {
           liste.Add(value);
        }

        // PUT api/<SensorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SensorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
