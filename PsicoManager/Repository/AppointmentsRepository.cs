using PsicoManager.Data.DTOs;
using PsicoManager.Services;
using PsicoManager.Services.Interfaces;

namespace PsicoManager.Repository
{
    public class AppointmentsRepository : IAppointmentsRepository
    {
        private readonly ILogger<AppointmentsRepository> _logger;

        public AppointmentsRepository(ILogger<AppointmentsRepository> logger)
        {
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
