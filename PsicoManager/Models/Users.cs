namespace PsicoManager.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public DateTime UpdateOn { get; set; }
    }
}
