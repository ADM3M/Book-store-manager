namespace Jul.Data
{
    public class Books
    {
        public int Id { get; set; }

        public int LibraryId { get; set; }

        public Libraries Library { get; set; }

        public int AuthorId { get; set; }

        public Authors Author { get; set; }

        public int GenreId { get; set; }

        public Genres Genre { get; set; }

        public int PublisherId { get; set; }

        public Publishers Publisher { get; set; }

        public string BookTitle { get; set; }

        public DateTime Year { get; set; }

        public double Price { get; set; }
    }
}
