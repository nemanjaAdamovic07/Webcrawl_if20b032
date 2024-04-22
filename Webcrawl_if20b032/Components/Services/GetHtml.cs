using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net.Http;
using System.Xml;
using userapi.Domain;
using Webcrawl_if20b032.Controllers;


namespace Webcrawl_if20b032.Components.Services
{
    public class GetHtml
    {
        private static readonly AppDbContext _appDbContext;
        public GetHtml(AppDbContext context)
        {
        }

        public static async Task<(List<string> pdfs, List<string> pages)> ParsePageLinks(string url)
        {
            List<string> pageLinks = new List<string>();
            List<string> pdfLinks = new List<string>();
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                //if (!Uri.TryCreate(hrefValue, UriKind.Absolute, out Uri result))
                //{
                //    result = new Uri(new Uri(url), hrefValue);
                //}
                Uri baseUri = new Uri(url);
                Uri absoluteUri = new Uri(baseUri, hrefValue);
                if (!absoluteUri.AbsoluteUri.StartsWith("mailto") && !absoluteUri.AbsoluteUri.StartsWith("tel"))
                {
                    if (absoluteUri.AbsoluteUri.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) && !pdfLinks.Contains(absoluteUri.ToString()))
                        pdfLinks.Add(absoluteUri.ToString());
                    else
                        if (!pageLinks.Contains(absoluteUri.ToString()))
                        pageLinks.Add(absoluteUri.ToString());
                }
            }
            return (pdfLinks, pageLinks);
        }
    }


    /* 
     
    STEP 1: Search Base URL

    STEP 2: Check Depth

    STEP 3.1 : Search Other URLs

    STEP 3.2: Download PDFs

    STEP 3.3 : Log Persistently Found Pages and PDF Files

    STEP 4: Show Downloaded PDFs in Profile and make them accessible (open)

    STEP 5: For each PDF count 10 most common words (exclude if, a, the etc.). Save the stats

    STEP 6: Search PDFs where a given word falls under 10 most common words used and filter those

    STEP 7: Worldclound for one, multiple, timeframe found PDF Files
     
     
     */
}
