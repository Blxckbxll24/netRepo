using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Interfaces;
using System.Threading.Tasks;
using ApplicationCore.Wrappers;

namespace Host.Controllers
{
    [Route("api/estudiantes")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudiantesService _service;

        public EstudianteController(IEstudiantesService service)
        {
            _service = service;
        }

        [HttpGet("getEstudiantes")]
        public async Task<IActionResult> GetEstudiantes()
        {
            var response = await _service.GetEstudiantes();
            return Ok(response);
        }
    }
}
