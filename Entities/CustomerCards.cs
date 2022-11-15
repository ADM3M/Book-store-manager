namespace Jul.Entities
{
    public class CustomerCards
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customers Customer { get; set; }

        public int BookId { get; set; }

        public Books Book { get; set; }

        public DateTime DateLanded { get; set; }
    }
}
