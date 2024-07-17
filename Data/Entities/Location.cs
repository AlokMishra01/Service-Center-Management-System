using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_Management_System.Data.Entities
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string Metro { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string GeoCoordinate { get; set; }
    }
}
