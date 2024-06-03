using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;

namespace Webcrawl_if20b032.Components.Controllers
{
    public class ParsePDF
    {
        public static async Task<Dictionary<string, int>> GetTopWordsFromPdfFiles(string[] pdfFilePaths)
        {

            var wordCount = new Dictionary<string, int>();

            foreach (var pdfFilePath in pdfFilePaths)
            {
                // Extract text from PDF
                string text = await ExtractTextFromPdf(pdfFilePath);

                // Tokenize text into words
                string[] words = await TokenizeText(text);

                // Count word frequency
                await CountWordFrequency(words, wordCount);
            }

            // Sort by frequency and take the top 10
            var topWords = wordCount.OrderByDescending(pair => pair.Value)
                                    .Take(10)
                                    .ToDictionary(pair => pair.Key, pair => pair.Value);

            return topWords;
        }

        private static async Task<string> ExtractTextFromPdf(string pdfFilePath)
        {
            await Task.Delay(1);
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                using (PdfDocument pdf = new PdfDocument(reader))
                {
                    string text = "";

                    for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
                    {
                        text += PdfTextExtractor.GetTextFromPage(pdf.GetPage(i));
                    }

                    return text;
                }
            }
        }

        private static async Task<string[]> TokenizeText(string text)
        {
            // Simple tokenization by splitting on whitespace
            await Task.Delay(1);
            return text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static async Task CountWordFrequency(string[] words, Dictionary<string, int> wordCount)
        {
            await Task.Delay(1);
            foreach (var word in words)
            {
                if (word.Length > 4)
                {
                    string cleanedWord = word.ToLower().Trim();

                    if (!string.IsNullOrWhiteSpace(cleanedWord))
                    {
                        if (wordCount.ContainsKey(cleanedWord))
                        {
                            wordCount[cleanedWord]++;
                        }
                        else
                        {
                            wordCount[cleanedWord] = 1;
                        }
                    }
                }

            }
        }
    }
}
