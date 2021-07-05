
namespace ResumeWebsite.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<string> Badges { get; set; }
        public IList<string> Certificates { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
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
        }
    }
}
