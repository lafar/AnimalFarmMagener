using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalFarmManager.Infrastructure.DTO;

namespace AnimalFarmManager.API.Controllers
{
    [Route("[controller]")]
    public class AnimalsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public AnimalDTO Get(int id)
        {
            return "value";
        }

        // POST api/values
     
    }
}
