
namespace ResumeWebsite.Pages
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.FileProviders;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class PersonalProfileModel : PageModel
    {
        public IList<Marathon> MarathonData { get; set; }
        public IList<Timeline> TimeLineList { get; set; }
        public IList<Timeline> IndiaData { get; set; }
        public IList<Timeline> UKData { get; set; }
        //public IList<Timeline> TimelineData { get; set; }

        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment webHostEnvironment;

        public PersonalProfileModel(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            this.webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            //string BlobURL = Configuration.GetSection("BlobURL").Value;
            //string SASToken = Configuration.GetSection("SASToken").Value;
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
            var UKImages = provider.GetDirectoryContents(Path.Combine("images", "PersonalProfile", "UK"));
            var objFiles = UKImages.OrderBy(m => m.LastModified);
            UKData = new List<Timeline>();

            foreach (var item in objFiles.ToList())
            {
                string[] fileinfo = item.Name.Split('_');
                UKData.Add(new Timeline()
                {
                    Date = DateTime.ParseExact(fileinfo[1], "yyyyMMdd", cultureInfo).ToString("dd MMM yyyy"),
                    DateInt = Convert.ToInt32(fileinfo[1]),
                    Location = fileinfo[2][0..^4],
                    Div01 = Path.Combine("images/PersonalProfile/UK", item.Name)
                });
            }

            TimeLineList = new List<Timeline>
            {
                new Timeline()
                {
                    Title = "title",
                    Date = "10 September",
                    Location = "Location",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg",
                    Div02 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                },
                new Timeline()
                {
                    Title = "Born",
                    Date = "10 September",
                    Location = "Mathura",
                    Div01 = "images/PersonalProfile/TL/ab_0011.jpg",
                    Div02 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                }
            };

            MarathonData = new List<Marathon>
            {
                new Marathon()
                {
                    Date = "26 Aug 2018",
                    Location = "Hyderabad",
                    TimeTaken = "02:23:15",
                    Div01 = "images/Marathon/IMG_20180826_193236.jpg",
                    Div02 = "https://www.timingindia.com/certificate/MzA4NTpINDAyOTo1NzE6JkkmNzY="
                },
                new Marathon()
                {
                    Date = "19 Nov 2017",
                    Location = "Delhi",
                    TimeTaken = "2:09:05",
                    Div01 = "images/Marathon/IMG_20171119_214349.jpg",
                    Div02 = $"images/Marathon/H13_Delhi2017.pdf"
                },
                new Marathon()
                {
                    Date = "20 Aug 2017",
                    Location = "Hyderabad",
                    TimeTaken = "2:12:50",
                    Div01 = "images/Marathon/IMG_20170820_214727.jpg",
                    Div02 = "https://www.timingindia.com/certificate/MjgzMzpIMjQwNzo0MTc6JkkmNzY="
                },
                new Marathon()
                {
                    Date = "16 Oct 2016",
                    Location = "Pune",
                    TimeTaken = "2:42:56",
                    Div01 = "images/Marathon/IMG_20161016_102626.jpg",
                    Div02 = "images/Marathon/H11_Pune.jpg"
                },
                new Marathon()
                {
                    Date = "28 Aug 2016",
                    Location = "Hyderabad",
                    TimeTaken = "2:33:29",
                    Div01 = "images/Marathon/IMG_20160828_091207.jpg",
                    Div02 = "images/Marathon/H10_Hyderabad.pdf"
                },
                new Marathon()
                {
                    Date = "29 Nov 2015",
                    Location = "Delhi",
                    TimeTaken = "2:08:44",
                    Div01 = "images/Marathon/IMG_20151129_100714.jpg",
                    Div02 = "images/Marathon/H09_Delhi_291115.pdf"
                },
                new Marathon()
                {
                    Date = "01 Nov 2015",
                    Location = "Gurgram",
                    TimeTaken = "02:06:07",
                    Div01 = "images/Marathon/IMG_20151101_081332.jpg",
                    Div02 = "images/Marathon/H08_Gurgoan_011115.pdf"
                },
                new Marathon() //H07
                {
                    Date = "30 Aug 2015",
                    Location = "Hyderabad",
                    TimeTaken = "02:15:28",
                    Div01 = "images/Marathon/IMG_20150830_090009.jpg",
                    Div02 = "https://www.timingindia.com/certificate/MjM5MDpIMjE3OToxOTc6JkkmNzY="
                },
                new Marathon() //H06
                {
                    Date = "26 Jul 2015",
                    Location = "Kathgodam",
                    TimeTaken = "00:00:00",
                    Div01 = "images/Marathon/IMG_20150726_091414.jpg",
                    Div02 = ""
                },
                new Marathon()
                {
                    Date = "10 May 2015",
                    Location = "Pune",
                    TimeTaken = "02:23:46",
                    Div01 = "images/Marathon/IMG_20150510_074109.jpg",
                    Div02 = "images/Marathon/H05_Pune_100515.pdf"
                },
                new Marathon()
                {
                    Date = "25 May 2015",
                    Location = "Kundalika",
                    TimeTaken = "02:48:20",
                    Div01 = "images/Marathon/IMG_20150328_092700.jpg",
                    Div02 = "images/Marathon/H04_Kundalika_28052015.pdf"
                },
                new Marathon()
                {
                    Date = "07 Dec 2014",
                    Location = "Pune",
                    TimeTaken = "01:55:11",
                    Div01 = "images/Marathon/IMG_20141207_022118.jpg",
                    Div02 = "images/Marathon/H03_Pune_071214.pdf"
                },
                new Marathon()
                {
                    Date = "24 Aug 2014",
                    Location = "Hyderabad",
                    TimeTaken = "02:23:26",
                    Div01 = "images/Marathon/IMG_20140824_095656.jpg",
                    Div02 = "images/Marathon/H02_Hyderabad_240814.pdf"
                },
                new Marathon()
                {
                    Date = "16 Feb 2014",
                    Location = "Mumbai",
                    TimeTaken = "02:26:24",
                    Div01 = "images/Marathon/IMG_20140216_044356.jpg",
                    Div02 = "images/Marathon/H01_Mumbai_160214.pdf"
                },
                new Marathon()
                {
                    Date = "27 Nov 2016",
                    Location = "Hyderabad",
                    TimeTaken = "00:57:49",
                    Div01 = "images/Marathon/IMG_20161127_060927.jpg",
                    Div02 = "images/Marathon/10k03_Hyderabad_27nov16.pdf"
                },
                new Marathon()
                {
                    Date = "30 March 14",
                    Location = "Pune",
                    TimeTaken = "00:50:00",
                    Div01 = "images/Marathon/IMG_20140330_095438.jpg",
                    Div02 = "images/Marathon/10k02_Pune_30mar14.png"
                },
                new Marathon()
                {
                    Date = "01 Dec 2013",
                    Location = "Pune",
                    TimeTaken = "00:54:10",
                    Div01 = "images/Marathon/IMG_20131201_084028.jpg",
                    Div02 = "images/Marathon/10k01_Pune_01dec13.pdf"
                }
            };

            IndiaData = new List<Timeline>
            {
                new Timeline()
                {
                    Date = "11 Jan 2020",
                    Location = "IN 01",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                },
                new Timeline()
                {
                    Date = "11 Jan 2020",
                    Location = "IN 01",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                },
                new Timeline()
                {
                    Date = "11 Jan 2020",
                    Location = "IN 01",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                },
                new Timeline()
                {
                    Date = "11 Jan 2020",
                    Location = "IN 01",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
                },
                new Timeline()
                {
                    Date = "11 Jan 2020",
                    Location = "IN 01",
                    Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
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
        public string Title { get; set; }
        public string Location { get; set; }
        public int DateInt { get; set; }
        public string Date { get; set; }
        public string Flight { get; set; }
        public string Div01 { get; set; }
        public string Div02 { get; set; }
    }
}
