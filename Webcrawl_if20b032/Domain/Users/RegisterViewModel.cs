using System.ComponentModel.DataAnnotations;

namespace Webcrawl_if20b032.Domain.Users
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid E-Mail address")]
        public string? email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a password")]
        public string? pw { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid E-Mail address")]
        public string? nickname { get; set; }
    }
}
