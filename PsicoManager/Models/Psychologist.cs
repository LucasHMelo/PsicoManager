namespace PsicoManager.Models
{
    public class Psychologist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CRP { get; set; }
        public int UserId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public DateTime UpdateOn { get; set; }

        public Users User { get; set; }
        public ICollection<Appointments> Appointment { get; set; }
        public ICollection<Patients> Patients { get; set; }
    }
}
