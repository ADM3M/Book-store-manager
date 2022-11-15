namespace Jul.Data
{
    public class Libraries
    {
        public int Id { get; set; }

        public ICollection<Books> Books { get; set; }
    }
}
