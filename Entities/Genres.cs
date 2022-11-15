namespace Jul.Entities
{
    public class Genres
    {
        public int Id { get; set; }

        public string GenreName { get; set; }

        public ICollection<Books> Books { get; set; }
    }
}
