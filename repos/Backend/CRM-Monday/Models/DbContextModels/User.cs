using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Monday.Models.DbContextModels
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserFullName { get; set; }
        //public string UserFirstName { get; private set; }       // TO-DO: make private
        //public string UserLastName { get; private set; }        // TO-DO: make private
        //public string SetUserFN { get { return UserFirstName + UserLastName; } set { UserFirstName= value; UserLastName = value; } }

        // Foreign Key - UserEmailId
        [ForeignKey("UserEmailId")]
        public int UserEmailRefId { get; set; }
        public UserEmailId UserEmailId { get; set; }

        // Foreign Key - UserContactDetails
        [ForeignKey("UserContactDetails")]
        public int UserContactRefId { get; set; }
        public UserContactDetails UserContactDetails { get; set; }
    }
}
