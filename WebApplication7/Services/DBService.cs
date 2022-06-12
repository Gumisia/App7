using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;
using WebApplication7.Models.DTO;

namespace WebApplication7.Services
{
    public class DBService : IDbService
    {
        private readonly MainDbContext _mainDbContext;

        public DBService(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }

        public async Task<string> AddDoctor(SomeKindOfDoctors request)
        {

            var newDoctor = new Doctor()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email

            };
            _mainDbContext.Add(newDoctor);
            await _mainDbContext.SaveChangesAsync();
            return "Doctor dodany";
        }

        public async Task<string> DeleteDoctor(int id)
        {
            var doctor = await _mainDbContext.Doctors.Where(e => e.IdDoctor == id).FirstOrDefaultAsync();
            if (doctor == null) return "NotFound";
            _mainDbContext.Attach(doctor);
            _mainDbContext.Remove(doctor);
            await _mainDbContext.SaveChangesAsync(); 
            return "Lekarz usunięty";
        }

        public async Task<string> EditDoctor(SomeKindOfDoctors request)
        {
            var editDoctor = await _mainDbContext.Doctors.Where(e => e.IdDoctor == request.IdDoctor).FirstOrDefaultAsync();
            editDoctor.FirstName = request.FirstName;
            editDoctor.LastName = request.LastName;
            editDoctor.Email = request.Email;
                
            _mainDbContext.Attach(editDoctor);
            await _mainDbContext.SaveChangesAsync();
            return "Doctor edytowany";

        }

        public async Task<IEnumerable<SomeKindOfDoctors>> GetDoctor(int id)
        {
            return await _mainDbContext.Doctors
                .Select(e => new SomeKindOfDoctors
                {
                    IdDoctor = e.IdDoctor,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,

                }).Where(e => e.IdDoctor == id).ToListAsync();
        }

        public async Task<IEnumerable<SomeKindOfDoctors>> GetDoctors()
        {
            return await _mainDbContext.Doctors
                .Select(e => new SomeKindOfDoctors
            {
                IdDoctor = e.IdDoctor,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,

            }).ToListAsync();
        }
    }
}
