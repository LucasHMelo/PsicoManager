using PsicoManager.Models;

namespace PsicoManager.Data.DTOs
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public DateTime Appointment { get; set; }
        public List<Psychologist> Psychologists { get; set; }
        public List<Patients> Patients { get; set; }
    }
}
