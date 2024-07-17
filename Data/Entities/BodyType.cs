using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Service_Center_Management_System.Data.Entities
{
    public class BodyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; } = string.Empty;
    }
}
