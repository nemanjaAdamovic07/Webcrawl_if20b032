namespace Webcrawl_if20b032.Domain.Files
{
    public class FileModel
    {
        
        public string Filepath { get; set; }
        public string FileName { get; set; }
        public Dictionary<string,int> commonwords { get; set; }

        public FileModel()
        {
        }
        public FileModel(string filepath, string filename, Dictionary<string,int> words)
        {
            Filepath = filepath;
            FileName = filename;
            commonwords = words;
        }
    }
}
