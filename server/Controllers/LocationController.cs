using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger, IConfiguration configuration)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]

        public IEnumerable<Location> Get()
        {
            return Enumerable.Empty<Location>();
        }


        [HttpGet]
        [Route("{locationId:int}")]

        public IEnumerable<Location> Get(int locationId)
        {
            return Enumerable.Empty<Location>();
        }

    }
}
