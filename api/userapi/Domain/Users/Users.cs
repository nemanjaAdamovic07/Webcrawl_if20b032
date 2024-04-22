using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace userapi.Domain.Users
{
    [Table("users")]
    public class Users
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

    }
}
