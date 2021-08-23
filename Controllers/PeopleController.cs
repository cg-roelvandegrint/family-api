using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Family.Api.Models;

namespace Family.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class PeopleController : ControllerBase
    {
        private static readonly IEnumerable<Person> People = new List<Person>
        {
            new Person("Roel", "van de Grint"),
            new Person("Mandy","Dirkse"),
            new Person("May","van de Grint"),
            new Person("Fenn","van de Grint")
                    };

        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return People;
        }
    }
}
