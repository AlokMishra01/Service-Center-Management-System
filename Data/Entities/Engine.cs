using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Center_Management_System.Data.Entities
{
    public enum StrokeType
    {
        Two, Four
    }

    public enum FuelType
    {
        Diseal, Petrol
    }

    public enum CombusitionType
    {
        Injection, Carburetor
    }

    public class Engine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        public StrokeType StrokeType { get; set; }
        public int NumberOfCylinders { get; set; }
        public int InletValvesPerCylinder { get; set; }
        public int OutletValvesPerCylinder { get; set; }
        public double BoreInMM { get; set; }
        public double StrokeInMM { get; set; }
        public string CompressionRatio { get; set; }
        public double MaxPowerInKW { get; set; }
        public int RPMForMaxPower { get; set; }
        public double MaxTorqueInNm { get; set; }
        public int RPMForMaxTorque { get; set; }
        public int IdelRPM { get; set; }
        public int FuleConsuptionForOneKWhInGram { get; set; }
        public int WeightInGram { get; set; }
        public FuelType FuelType { get; set; }
        public CombusitionType CombusitionType { get; set; }
        public string Description { get; set; }
    }
}
