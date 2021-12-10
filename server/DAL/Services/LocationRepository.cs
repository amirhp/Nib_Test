using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.DAL.Services {
	public class LocationRepository : ILocationRepository
    {
        public async Task<IList<Location>> GetAsync()
        {
            string fileName = "Data.json";
            using FileStream openStream = File.OpenRead(fileName);

            IList<Location> jobs =
                await JsonSerializer.DeserializeAsync<IList<Location>>(openStream);

            return jobs;
        }

        public void Save()
		{
			//saves the invoice to the json
		}

		public void Add( Location invoice )
		{
		}
        public Task<Location> GetLocationByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}