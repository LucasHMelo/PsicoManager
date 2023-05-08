using PsicoManager.Controllers;
using PsicoManager.Data.DTOs;
using PsicoManager.Services.Interfaces;

namespace PsicoManager.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly IAppointmentsRepository _appointmentsRepository;
        private readonly ILogger<AppointmentsService> _logger;

        public AppointmentsService(IAppointmentsRepository appointmentsRepository, ILogger<AppointmentsService> logger)
        {
            _appointmentsRepository = appointmentsRepository;
            _logger = logger;
        }

        public async Task<List<AppointmentDTO>> GetAllAppointmentsFromPsychologist(int psychologistId)
        {
            //var appointments = await _appointmentsRepository.
            //if (appointmentDTO == null)
            //{
            //    return null;
            //}

            return null;
        }
    }
}
