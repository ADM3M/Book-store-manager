namespace Jul.Entities
{
    public class Publishers
    {
        public int Id { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Books> PublisherBooks { get; set; }
    }
}
