namespace Jul.Entities
{
    public class Customers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public int CountryId { get; set; }

        public Countries Country { get; set; }

        public int CityId { get; set; }

        public Cities City { get; set; }
    }
}
