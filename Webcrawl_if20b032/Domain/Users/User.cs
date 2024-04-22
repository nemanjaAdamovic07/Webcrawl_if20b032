using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace userapi.Domain.Users
{
    [Table("users")]
    public class User
    {
        [Key]
        [Required]
        [Column("email")]
        public string email { get; set; }
        [Required]
        [Column("pw")]
        public string password { get; set; }
        [Column("nickname")]
        public string nickname { get; set; }
        public User()
        {
                
        }
        public User(string Email, string Password, string Nickname)
        {
            email = Email;
            password = Password;
            nickname = Nickname;
        }

    }
}
