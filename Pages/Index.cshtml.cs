
namespace ResumeWebsite.Pages
{
    using HtmlAgilityPack;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ResumeWebsite.ViewModels;
    using Microsoft.Extensions.Configuration;

    public class IndexModel : PageModel
    {
        public IConfiguration Configuration { get; }
        private readonly ILogger<IndexModel> _logger;
        public IList<string> Badges { get; set; }
        public IList<BadgesfromCredly> CredlyBadges { get; set; }
        public IList<string> Technologies { get; set; }
        public IList<string> Certificates { get; set; }

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public void OnGet()
        {
            string BlobURL = Configuration.GetSection("BlobURL").Value;
            string SASToken = Configuration.GetSection("SASToken").Value;

            System.Net.WebClient webClient = new System.Net.WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };

            string url = string.Format("https://www.credly.com/users/singhkuldeep/badges");

            string result = webClient.DownloadString(url);

            var _doc = new HtmlDocument();
            _doc.LoadHtml(result);

            IEnumerable<HtmlNode> nodes = _doc.DocumentNode.Descendants().Where(n => n.HasClass("data-table-row-grid"));
            CredlyBadges = new List<BadgesfromCredly>()
            {
                new BadgesfromCredly
                {
                    Title = "Accredited: Azure Cosmos DB",
                    SubTitle = "Microsoft Learn",
                    BadgeURL = string.Format("{0}/images/Badges/cosmosL200.jpg{1}", BlobURL, SASToken),
                    BadgeURLFallBack = "",
                    CertificateURL = ""
                },
                new BadgesfromCredly
                {
                    Title = "Accredited: Azure Data Factory",
                    SubTitle = "Microsoft Learn",
                    BadgeURL = string.Format("{0}/images/Badges/adf.png{1}", BlobURL, SASToken),
                    BadgeURLFallBack = "",
                    CertificateURL = ""
                },
            };
            foreach (var item in nodes)
            {
                var item01 = item.Descendants().Where(n => n.HasClass("cr-standard-grid-item-content__title")).FirstOrDefault();
                var item02 = item.Descendants().Where(n => n.HasClass("cr-standard-grid-item-content__subtitle")).FirstOrDefault();
                var item03 = item.Descendants("img").FirstOrDefault();
                var item04 = item.Descendants("a").FirstOrDefault();

                CredlyBadges.Add(new BadgesfromCredly
                {
                    Title = item01.InnerText.Trim(),
                    SubTitle = item02.InnerText.Trim(),
                    BadgeURL = string.Format("{1}/images/Badges/{0}.png{2}", item01.InnerText.Trim().Replace(" ", "").Replace(":", ""), BlobURL, SASToken),
                    BadgeURLFallBack = item03.Attributes["src"].Value,
                    CertificateURL = string.Format("https://www.credly.com/{0}", item04.Attributes["href"].Value)
                });
            }

            Badges = new List<string>
            {
                string.Format("{0}/images/Badges/01-AzSolutionArchitect-badge.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/02-DevOpsExpert-badge.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/03-AzDataEngineer-badge.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/04-DataAnalystAssociate-badge.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/04-DatabaseAdministrator-badge.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/azureAdministrator600.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/azuredeveloperassociate600.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/adf.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/cosmosL200.jpg{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/accessibility.png{1}", BlobURL, SASToken),
                //"images/Badges/xamarin.png",
                string.Format("{0}/images/Badges/01-exam-az300.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/01-exam-az301.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/02-exam-az400.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/03-exam-dp200.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Badges/03-exam-dp201.png{1}", BlobURL, SASToken)
            };

            Certificates = new List<string>
            {
                string.Format("{0}/images/Certificates/5.AzureCertificate.jpg{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/01-AzSolutionArchitect-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/02-DevOpsExpert-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/03-AzDataEngineer-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/04-DataAnalystAssociate-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/04-DatabaseAdministrator-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/05-AzAdminAssociate-cert.png{1}", BlobURL, SASToken),
                string.Format("{0}/images/Certificates/06-DevAssociate-cert.png{1}", BlobURL, SASToken)
            };

            Technologies = new List<string>
            {
                ".net(C#)",
                ".net CORE",
                "PowerShell",
                "Azure Web/ Compute",
                "Azure SQL",
                "Cosmos DB",
                "Azure Storage",
                "Azure Data Factory",
                "Azure Synapse",
                "Eventing and Messeging",
                "Application Monitoring",
                "Azure Automation",
                "Azure DevOps",
                "Power BI",
                "Agile / Scrum",
                "Solution Design"
            };
        }
    }
}
