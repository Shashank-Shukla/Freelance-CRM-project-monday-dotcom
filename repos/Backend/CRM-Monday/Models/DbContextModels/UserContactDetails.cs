using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Monday.Models.DbContextModels
{
    public class UserContactDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Foreign Key - CountryCode
        [Required]
        [ForeignKey("CountryCode")]
        public int CountryCodeRefId { get; set; }
        public CountryCode CountryCode { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber1 { get; set; }
        [StringLength(10)]
        public string PhoneNumber2 { get; set; }
    }
}
