using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcrawl_if20b032.Domain.Users
{
    [Table("userhistory")]
    public class UserHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id{ get; set; }

        [Required]
        [Column("email")]
        public string email { get; set; }
        [Required]
        [Column("time")]
        public string time { get; set; }
        [Column("url")]
        public string url { get; set; }

        [Column("foundpdfs")]
        public List<string> foundpdfs { get; set; }
        [Column("searchedurls")]
        public List<string> searchedurls { get; set; }
        public UserHistory()
        {
                
        }

        public UserHistory(string Email, string Url, List<String> Found, List<string> searchedurls)
        {
            email = Email;
            url = Url;
            foundpdfs = Found;
            time = DateTime.Now.ToString();
            this.searchedurls = searchedurls;
        }
    }
}
