using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<string> Badges { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Badges = new List<string>
            {
                "images/01-AzSolutionArchitect-badge.png",
                "images/02-DevOpsExpert-badge.png",
                "images/03-AzDataEngineer-badge.png",
                "images/04-DataAnalystAssociate-badge.png",
                "images/04-DatabaseAdministrator-badge.png",
                "images/azureAdministrator600.png",
                "images/azuredeveloperassociate600.png",
                "images/adf.png",
                "images/cosmosL200.jpg",
                "images/accessibility.png",
                //"images/xamarin.png",
                "images/01-exam-az300.png",
                "images/01-exam-az301.png",
                "images/02-exam-az400.png",
                "images/03-exam-dp200.png",
                "images/03-exam-dp201.png"
            };
        }
    }
}
