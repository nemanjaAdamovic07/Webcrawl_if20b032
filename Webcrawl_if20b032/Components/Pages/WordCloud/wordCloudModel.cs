namespace Webcrawl_if20b032.Components.Pages.WordCloud
{
    public class wordCloudModel
    {
        public List<CheckboxOption>? checkboxes { get; set; } = new List<CheckboxOption>();

    }

    public class CheckboxOption
    {
        public bool isChecked { get; set; } = false;
        public string? name { get; set; }

        public CheckboxOption() { }

    }
}
