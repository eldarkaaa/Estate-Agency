using Estate_Agency.Models.Data;

namespace Estate_Agency.Models
{
    public class SearchOrder
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public int Beds { get; set; }
        public int Garages { get; set; }
        public int Washrooms { get; set; }
        public string Cost { get; set; }
    }
}
