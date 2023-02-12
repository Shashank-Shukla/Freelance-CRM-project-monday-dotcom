using System.ComponentModel.DataAnnotations;

namespace CRM_Monday.Models.InputModels
{
    public class UserLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Country_Code { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
    }
}
