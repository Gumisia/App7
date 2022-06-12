using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication7.Models.DTO;

namespace WebApplication7.Services
{
    public interface IDbService
    {
        Task<IEnumerable<SomeKindOfDoctors>> GetDoctors();
        Task<IEnumerable<SomeKindOfDoctors>> GetDoctor(int id);

        Task<string> AddDoctor(SomeKindOfDoctors request);
        Task<string> EditDoctor(SomeKindOfDoctors request);
        Task<string> DeleteDoctor(int id);
    }
}
