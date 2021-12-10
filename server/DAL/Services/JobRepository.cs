using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.DAL.Services
{
    public class JobRepository : IJobRepository
    {
		public async Task<IList<Job>> GetAsync()
        {
            string fileName = "Data.json";
            using FileStream openStream = File.OpenRead(fileName);

            IList<Job> jobs =
                await JsonSerializer.DeserializeAsync<IList<Job>>(openStream);

			return jobs;
		}

		public void Save()
		{
			//saves the invoice to the json
		}

		public void Add( Job invoice )
		{
		}

        public Task<Job> GetJobByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}