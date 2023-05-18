namespace StudentRecords.API.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; } = null!;

        public string AddressLine2 { get; set; } = null!;

        public string AddressLine3 { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Postcode { get; set; } = null!;

        public string Country { get; set; } = null!;
    }
}