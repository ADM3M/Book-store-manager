namespace Jul.Entities
{
    public class Authors
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public ICollection<Books> AuthorBooks { get; set; }
    }
}
