namespace Jul.Entities
{
    public class Receipts
    {
        public int Id { get; set; }

        public int CustomerCardId { get; set; }

        public CustomerCards CustomerCard { get; set; }

        public DateTime DateSold { get; set; }
    }
}
