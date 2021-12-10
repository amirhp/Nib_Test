using System.Collections.Generic;
using System.Threading.Tasks;

namespace NIB_Test_Server.DAL.Interfaces
{
    public interface IRepository<T>
    {
        Task<IList<T>> GetAsync();

        void Save();

        void Add(T data);

    }
}