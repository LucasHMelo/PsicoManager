using PsicoManager.Data.DTOs;

namespace PsicoManager.Services.Interfaces
{
    public interface IAppointmentsService
    {
        Task<List<AppointmentDTO>> GetAllAppointmentsFromPsychologist(int id);
    }
}