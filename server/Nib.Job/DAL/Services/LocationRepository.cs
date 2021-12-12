using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Model;
using RestSharp;

namespace NIB_Test_Server.DAL.Services {
	public class LocationRepository : ILocationRepository
    {
        private readonly IConfiguration _configuration;

        public LocationRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IList<Location>> GetAsync()
        {
            var client = new RestClient(_configuration.GetSection("ApiLocation").Value);
            var request = new RestRequest("location", DataFormat.Json);
            var locations = await client.GetAsync<IList<Location>>(request);

            return locations;
        }

        public void Save()
		{
		}

		public void Add( Location location )
		{
		}
        public Task<Location> GetLocationByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}