using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILogger<LocationController> logger, ILocationRepository locationRepository)
        {
            _logger = logger;
            _locationRepository = locationRepository;

        }

        [HttpGet]
        [Route("")]

        public async Task<IEnumerable<Location>> GetAsync()
        {
            return await _locationRepository.GetAsync();
        }


        [HttpGet]
        [Route("{locationId:int}")]

        public IEnumerable<Location> Get(int locationId)
        {
            return Enumerable.Empty<Location>();
        }

    }
}
