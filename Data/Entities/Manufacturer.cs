using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_Management_System.Data.Entities
{
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string About { get; set; }
        public DateOnly Founded { get; set; }
        public ContactInformation Contact { get; set; }
        public Location Location { get; set; }
        public FileDetails Logo { get; set; }

    }
}
