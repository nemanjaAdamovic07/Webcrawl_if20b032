using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace userapi.Domain.Users
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid E-Mail address")]
        public string? email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a password")]
        public string? pw { get; set; }
    }
}
