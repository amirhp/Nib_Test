using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NIB_Test_Server.DAL;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ILogger<JobController> _logger;
        private readonly IJobRepository _jobRepository;

        

        public JobController(ILogger<JobController> logger, IJobRepository  jobRepository)
        {
            _logger = logger;
            _jobRepository = jobRepository;
        }

        [HttpGet]
        [Route("")]

        public async Task<IEnumerable<Job>> GetAsync()
        {
            return await _jobRepository.Get();
        }


        [HttpGet]
        [Route("{JobId:int}")]

        public IEnumerable<Job> Get(int JobId)
        {
            return Enumerable.Empty<Job>();
        }

    }
}
