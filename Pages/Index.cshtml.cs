
namespace ResumeWebsite.Pages
{
    using HtmlAgilityPack;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ResumeWebsite.ViewModels;

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<string> Badges { get; set; }
        public IList<BadgesfromCredly> CredlyBadges { get; set; }
        public IList<string> Technologies { get; set; }
        public IList<string> Certificates { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

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
                    BadgeURL = "images/Badges/cosmosL200.jpg",
                    BadgeURLFallBack = "images/Badges/cosmosL200.jpg",
                    CertificateURL = ""
                },
                new BadgesfromCredly
                {
                    Title = "Accredited: Azure Data Factory",
                    SubTitle = "Microsoft Learn",
                    BadgeURL = "images/Badges/adf.png",
                    BadgeURLFallBack = "images/Badges/adf.png",
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
                    BadgeURL = string.Format("images/Badges/{0}.png", item01.InnerText.Trim().Replace(" ", "").Replace(":", "")),
                    BadgeURLFallBack = item03.Attributes["src"].Value,
                    CertificateURL = string.Format("https://www.credly.com/{0}", item04.Attributes["href"].Value)
                });
            }

            Badges = new List<string>
            {
                "images/Badges/01-AzSolutionArchitect-badge.png",
                "images/Badges/02-DevOpsExpert-badge.png",
                "images/Badges/03-AzDataEngineer-badge.png",
                "images/Badges/04-DataAnalystAssociate-badge.png",
                "images/Badges/04-DatabaseAdministrator-badge.png",
                "images/Badges/azureAdministrator600.png",
                "images/Badges/azuredeveloperassociate600.png",
                "images/Badges/adf.png",
                "images/Badges/cosmosL200.jpg",
                "images/Badges/accessibility.png",
                //"images/Badges/xamarin.png",
                "images/Badges/01-exam-az300.png",
                "images/Badges/01-exam-az301.png",
                "images/Badges/02-exam-az400.png",
                "images/Badges/03-exam-dp200.png",
                "images/Badges/03-exam-dp201.png"
            };

            Certificates = new List<string>
            {
                "images/Certificates/5.AzureCertificate.jpg",
                "images/Certificates/01-AzSolutionArchitect-cert.png",
                "images/Certificates/02-DevOpsExpert-cert.png",
                "images/Certificates/03-AzDataEngineer-cert.png",
                "images/Certificates/04-DataAnalystAssociate-cert.png",
                "images/Certificates/04-DatabaseAdministrator-cert.png",
                "images/Certificates/05-AzAdminAssociate-cert.png",
                "images/Certificates/06-DevAssociate-cert.png"

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
