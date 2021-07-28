
namespace ResumeWebsite.ViewModels
{
    using System.Collections.Generic;

    public class PersonalProfilePage
    {
        public string SectionId { get; set; }

        public string PageTitle { get; set; }

        public List<Timeline> SectionFiles { get; } = new List<Timeline>();
    }

    public class Marathon
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string TimeTaken { get; set; }
        public string Div01 { get; set; }
        public string Div02 { get; set; }
    }

    public class Timeline
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public int DateInt { get; set; }
        public string Date { get; set; }
        public string Flight { get; set; }
        public string Div01 { get; set; }
        public string Div02 { get; set; }
    }

    public class BadgesfromCredly
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string BadgeURL { get; set; }
        public string BadgeURLFallBack { get; set; }
        public string CertificateURL { get; set; }

    }
}
