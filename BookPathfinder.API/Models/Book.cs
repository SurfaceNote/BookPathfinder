namespace BookPathfinder.API.Models
{
    using BookPathfinder.API.Enums;

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public ReadingStatus Status { get; set; }
        public string Notes { get; set; }
    }
}
