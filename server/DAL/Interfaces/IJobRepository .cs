using System.Threading.Tasks;
using NIB_Test_Server.DAL.Model;

namespace NIB_Test_Server.DAL.Interfaces
{
    public interface IJobRepository : IRepository<Job>
    {
        Job GetJobById(int id);
    }

}