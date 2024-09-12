namespace BookPathfinder.API.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int PagesRead { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
