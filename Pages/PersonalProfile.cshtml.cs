using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeWebsite.Pages
{
    public class PersonalProfileModel : PageModel
    {
        public IList<Marathon> MarathonData { get; set; }
        public IList<Timeline> TimelineData { get; set; }

        public void OnGet()
        {
            MarathonData = new List<Marathon>
            {
                new Marathon()
                {
                    Date = "26 Aug 2018",
                    Location = "Hyderabad",
                    TimeTaken = "02:23:15",
                    Div01 = "{0}/H14_Hyderabad2018.pdf{1}",
                    Div02 = "{0}/H14_Hyderabad2018.pdf{1}"
                },
                new Marathon()
                {
                    Date = "19 Nov 2017",
                    Location = "Delhi",
                    TimeTaken = "2:09:05",
                    Div01 = "{0}/H13_Delhi2017.pdf{1}",
                    Div02 = "{0}/H13_Delhi2017.pdf{1}"
                },
                new Marathon()
                {
                    Date = "20 Aug 2017",
                    Location = "Hyderabad",
                    TimeTaken = "2:12:50",
                    Div01 = "{0}/H12_Hyderabad2017.pdf{1}",
                    Div02 = "{0}/H12_Hyderabad2017.pdf{1}"
                },
                new Marathon()
                {
                    Date = "16 Oct 2016",
                    Location = "Pune",
                    TimeTaken = "2:42:56",
                    Div01 = "{0}/H11_Pune.jpg{1}",
                    Div02 = "{0}/H11_Pune.jpg{1}"
                },
                new Marathon()
                {
                    Date = "28 Aug 2016",
                    Location = "Hyderabad",
                    TimeTaken = "2:33:29",
                    Div01 = "{0}/H10_Hyderabad.pdf{1}",
                    Div02 = "{0}/H10_Hyderabad.pdf{1}"
                },
                new Marathon()
                {
                    Date = "29 Nov 2015",
                    Location = "Delhi",
                    TimeTaken = "2:08:44",
                    Div01 = "{0}/H09_Delhi_291115.pdf{1}",
                    Div02 = "{0}/H09_Delhi_291115.pdf{1}"
                },
                new Marathon()
                {
                    Date = "01 Nov 2015",
                    Location = "Gurgram",
                    TimeTaken = "02:06:07",
                    Div01 = "{0}/H08_Gurgoan_011115.pdf{1}",
                    Div02 = "{0}/H08_Gurgoan_011115.pdf{1}"
                },
                new Marathon()
                {
                    Date = "26 Jul 2015",
                    Location = "Kathgodam",
                    TimeTaken = "00:00:00",
                    Div01 = "",
                    Div02 = ""
                },
                new Marathon()
                {
                    Date = "10 May 2015",
                    Location = "Pune",
                    TimeTaken = "02:23:46",
                    Div01 = "{0}/H05_Pune_100515.pdf{1}",
                    Div02 = "{0}/H05_Pune_100515.pdf{1}"
                },
                new Marathon()
                {
                    Date = "25 May 2015",
                    Location = "Kundalika",
                    TimeTaken = "02:48:20",
                    Div01 = "",
                    Div02 = "{0}/H04_Kundalika_28052015.pdf{1}"
                },
                new Marathon()
                {
                    Date = "07 Dec 2014",
                    Location = "Pune",
                    TimeTaken = "01:55:11",
                    Div01 = "",
                    Div02 = "{0}/H03_Pune_071214.pdf{1}"
                },
                new Marathon()
                {
                    Date = "24 Aug 2014",
                    Location = "Hyderabad",
                    TimeTaken = "02:23:26",
                    Div01 = "",
                    Div02 = "{0}/H02_Hyderabad_240814.pdf{1}"
                },
                new Marathon()
                {
                    Date = "16 Feb 2014",
                    Location = "Mumbai",
                    TimeTaken = "02:26:24",
                    Div01 = "",
                    Div02 = "{0}/H01_Mumbai_160214.pdf{1}"
                },
                new Marathon()
                {
                    Date = "30 March 14",
                    Location = "Pune",
                    TimeTaken = "00:50:00",
                    Div01 = "",
                    Div02 = "{0}/10k02_Pune_30mar14.png{1}"
                },
                new Marathon()
                {
                    Date = "01 Dec 2013",
                    Location = "Pune",
                    TimeTaken = "00:54:10",
                    Div01 = "",
                    Div02 = "{0}/10k01_Pune_01dec13.pdf{1}"
                },
                new Marathon()
                {
                    Date = "27 Nov 2016",
                    Location = "Hyderabad",
                    TimeTaken = "00:57:49",
                    Div01 = "",
                    Div02 = "{0}/10k03_Hyderabad_27nov16.pdf{1}"
                }
            };

            TimelineData = new List<Timeline>
            {
                new Timeline()
                {
                    Date = "a",
                    Location = "a",
                    Flight = "DEL->LHR->LHR",
                    Div01 = "{0}/10k02_Pune_30mar14.png{1}",
                    Div02 = "{0}/H11_Pune.jpg{1}"
                },
                new Timeline()
                {
                    Date = "a1",
                    Location = "a1",
                    Flight = "LHR -> BCN -> LHR",
                    Div01 = "{0}/10k02_Pune_30mar14.png{1}",
                    Div02 = "{0}/H11_Pune.jpg{1}"
                }
            };

        }
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
        public string Location { get; set; }
        public string Date { get; set; }
        public string Flight { get; set; }
        public string Div01 { get; set; }
        public string Div02 { get; set; }
    }
}
