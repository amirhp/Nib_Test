using System.Threading.Tasks;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.DAL
{
    public interface IJobRepository : IRepository<Job>
    {
        Task<Job> GetJobByIdAsync(int id);
    }

}