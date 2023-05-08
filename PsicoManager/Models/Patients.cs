namespace PsicoManager.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int PsychologistId { get; set; }
        public DateTime BirthDate { get; set; }        
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public DateTime UpdateOn { get; set; }

        public Users User { get; set; }
        public ICollection<Appointments> Appointment { get; set; }
        public Psychologist Psychologist { get; set; }
    }
}
