namespace PsicoManager.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime Appointment { get; set; }
        public int PsychologistId { get; set; }
        public int PatientId { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public DateTime UpdateOn { get; set; }
        public Psychologist Psychologist { get; set; }
        public Patients Patient { get; set; }

    }
}
