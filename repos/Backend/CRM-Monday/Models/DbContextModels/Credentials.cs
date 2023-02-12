using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Monday.Models.DbContextModels
{
    public class Credentials
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Foreign Key
        [ForeignKey("UserEmailId")]
        public int UserEmailRefId { get; set; }
        public UserEmailId UserEmailId { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }

        public Credentials(string userName, string passWord)
        {
            UserName = userName;
            Password = passWord;
        }
    }
}
