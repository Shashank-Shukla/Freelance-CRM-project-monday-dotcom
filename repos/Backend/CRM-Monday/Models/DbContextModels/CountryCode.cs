using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Monday.Models.DbContextModels
{
    public class CountryCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Country_Code { get; set; }
        [Required]
        public string Country_Name { get; set; }
    }
}
