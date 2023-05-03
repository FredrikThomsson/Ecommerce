namespace GrupparbeteMVC.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public string? Reply { get; set; }

        
    }

}
