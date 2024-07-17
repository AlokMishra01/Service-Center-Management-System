using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_Management_System.Data.Entities
{
    /// Schema refrence
    /// https://schema.org/Vehicle
    /// 
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string VinNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public VehicleType VehicleType { get; set; }
        public BodyType BodyType { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Engine Engine { get; set; }
        public double CargoVolumeInLiter { get; set; }
        public double FuelCapacityInLiter { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public ICollection<FileDetails> Photos { get; set; }
        public string Description { get; set; }
    }
}
