using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication7.Models.DTO;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDbService _idbservice;
        public DoctorController(IDbService idbservice)
        {
            _idbservice = idbservice;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var doctor = await _idbservice.GetDoctor(id);
            return Ok(doctor);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> EditDoctor(SomeKindOfDoctors someKindOfDoctor)
        {
            var doctor = await _idbservice.EditDoctor(someKindOfDoctor);
            return Ok(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _idbservice.GetDoctors();
            return Ok(doctors);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctor = await _idbservice.DeleteDoctor(id);
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor(SomeKindOfDoctors someKindOfDoctor)
        {
            try
            {
                var doctor = await _idbservice.AddDoctor(someKindOfDoctor);
                return Ok(doctor);
            }
            catch (System.Exception)
            {
                return Conflict();
            }
        }
    }
}
