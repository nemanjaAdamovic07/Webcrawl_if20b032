using System.ComponentModel.DataAnnotations;

namespace Webcrawl_if20b032.Components.Pages.FetchData
{
    public class FetchDataModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid E-Mail address")]
        public string? url { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a depth")]
        public string? depth { get; set; }
    }
}
