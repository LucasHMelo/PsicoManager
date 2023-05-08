using Microsoft.AspNetCore.Mvc;
using PsicoManager.Models;
using PsicoManager.Services;
using PsicoManager.Services.Interfaces;

namespace PsicoManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly IAppointmentsService _appointmentsService;


        public AppointmentController(ILogger<AppointmentController> logger,
               IAppointmentsService appointmentsService)
        {
            _logger = logger;
            _appointmentsService = appointmentsService;
        }

        [HttpGet(Name = "Appointments")]
        public async Task<ActionResult<IList<Appointments>>> Get([FromQuery] int psychologistId)
        {
            var appointments = _appointmentsService.GetAllAppointmentsFromPsychologist(psychologistId);
            if (appointments == null)
            {
                return BadRequest();
            }

            return Ok(appointments);
        }
    }
}