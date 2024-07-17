using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_Management_System.Data.Entities
{
    public class FileDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public String Type { get; set; }
        public long Length { get; set; }
    }
}
