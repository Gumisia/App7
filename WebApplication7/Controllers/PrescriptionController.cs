using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IDbService _idbservice;
        public PrescriptionController(IDbService idbservice)
        {
            _idbservice = idbservice;
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> GetPrescription(int id)
        //{
        //    var perception = await _idbservice.GetPrescription(id);
        //    return Ok(perception);
        //}
    }
}
