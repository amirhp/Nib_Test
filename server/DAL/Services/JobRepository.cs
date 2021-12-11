using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            return await JsonSerializer.DeserializeAsync<IList<Job>>(openStream);
		}

		public void Save()
		{
		}

		public void Add( Job location )
		{
		}

        public Job GetJobById(int id)
        {
            return GetAsync().Result.FirstOrDefault(x=>x.Id == id);
        }
    }
}