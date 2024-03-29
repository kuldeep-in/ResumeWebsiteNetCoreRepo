
namespace ResumeWebsite.Pages
{
    using Azure;
    using Azure.Storage.Blobs;
    using Azure.Storage.Blobs.Models;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.FileProviders;
    using ResumeWebsite.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    public class PersonalProfileModel : PageModel
    {
        //public IList<Marathon> MarathonData { get; set; }
        //public IList<Timeline> TimeLineList { get; set; }
        //public PersonalProfilePage NLData { get; set; }
        //public PersonalProfilePage IndiaData { get; set; }
        //public PersonalProfilePage UKData { get; set; }
        //public PersonalProfilePage USAData { get; set; }
        //public PersonalProfilePage SEAData { get; set; }
        //public PersonalProfilePage DEData { get; set; }
        //public IList<Timeline> TimelineData { get; set; }

        //public IConfiguration Configuration { get; }
        //private readonly IWebHostEnvironment webHostEnvironment;
        //public string BlobURL;
        //public string SASToken;

        //public PersonalProfileModel(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        //{
        //    Configuration = configuration;
        //    this.webHostEnvironment = webHostEnvironment;
        //}

        public PersonalProfileModel()
        {

        }

        public async Task OnGet()
        {
            //BlobURL = Configuration.GetSection("BlobURL").Value;
            //SASToken = Configuration.GetSection("SASToken").Value;

            //UKData = await GetFilesFromStorage("tabUK", "UK", "images/PersonalProfile/UK");
            //IndiaData = await GetFilesFromStorage("tabIN", "India", "images/PersonalProfile/IN");
            //USAData = await GetFilesFromStorage("tabUSA", "USA", "images/PersonalProfile/USA"); ;
            //NLData = await GetFilesFromStorage("tabNL", "NL", "images/PersonalProfile/NL"); ;
            //SEAData = await GetFilesFromStorage("tabSEA", "SEA", "images/PersonalProfile/SEA"); ;
            //DEData = await GetFilesFromStorage("tabDE", "Germany", "images/PersonalProfile/DE"); ;

            //TimeLineList = new List<Timeline>
            //{
            //    new Timeline()
            //    {
            //        Title = "title",
            //        Date = "10 September",
            //        Location = "Location",
            //        Div01 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg",
            //        Div02 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
            //    },
            //    new Timeline()
            //    {
            //        Title = "Born",
            //        Date = "10 September",
            //        Location = "Mathura",
            //        Div01 = "images/PersonalProfile/TL/ab_0011.jpg",
            //        Div02 = "images/PersonalProfile/UK/IMG_20191226_150721~2.jpg"
            //    }
            //};

            //MarathonData = new List<Marathon>
            //{
            //    new Marathon()
            //    {
            //        Date = "26 Aug 2018",
            //        Location = "Hyderabad",
            //        TimeTaken = "02:23:15",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20180826_193236.jpg{1}", BlobURL, SASToken),
            //        Div02 = "https://www.timingindia.com/certificate/MzA4NTpINDAyOTo1NzE6JkkmNzY="
            //    },
            //    new Marathon()
            //    {
            //        Date = "28 Jan 2018",
            //        Location = "Hampi",
            //        TimeTaken = "00:00:00",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20180126_163055016_Hampi.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/IMG_20180126_163055017_Hampi.jpg{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "19 Nov 2017",
            //        Location = "Delhi",
            //        TimeTaken = "2:09:05",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20171119_214349.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H13_Delhi2017.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "20 Aug 2017",
            //        Location = "Hyderabad",
            //        TimeTaken = "2:12:50",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20170820_214727.jpg{1}", BlobURL, SASToken),
            //        Div02 = "https://www.timingindia.com/certificate/MjgzMzpIMjQwNzo0MTc6JkkmNzY="
            //    },
            //    new Marathon()
            //    {
            //        Date = "16 Oct 2016",
            //        Location = "Pune",
            //        TimeTaken = "2:42:56",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20161016_102626.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H11_Pune.jpg{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "28 Aug 2016",
            //        Location = "Hyderabad",
            //        TimeTaken = "2:33:29",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20160828_091207.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H10_Hyderabad.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "29 Nov 2015",
            //        Location = "Delhi",
            //        TimeTaken = "2:08:44",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20151129_100714.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H09_Delhi_291115.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "01 Nov 2015",
            //        Location = "Gurgram",
            //        TimeTaken = "02:06:07",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20151101_081332.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H08_Gurgoan_011115.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon() //H07
            //    {
            //        Date = "30 Aug 2015",
            //        Location = "Hyderabad",
            //        TimeTaken = "02:15:28",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20150830_090009.jpg{1}", BlobURL, SASToken),
            //        Div02 = "https://www.timingindia.com/certificate/MjM5MDpIMjE3OToxOTc6JkkmNzY="
            //    },
            //    new Marathon() //H06
            //    {
            //        Date = "26 Jul 2015",
            //        Location = "Kathgodam",
            //        TimeTaken = "00:00:00",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20150726_091414.jpg{1}", BlobURL, SASToken),
            //        Div02 = ""
            //    },
            //    new Marathon()
            //    {
            //        Date = "10 May 2015",
            //        Location = "Pune",
            //        TimeTaken = "02:23:46",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20150510_074109.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H05_Pune_100515.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "25 May 2015",
            //        Location = "Kundalika",
            //        TimeTaken = "02:48:20",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20150328_092700.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H04_Kundalika_28052015.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "07 Dec 2014",
            //        Location = "Pune",
            //        TimeTaken = "01:55:11",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20141207_022118.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H03_Pune_071214.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "24 Aug 2014",
            //        Location = "Hyderabad",
            //        TimeTaken = "02:23:26",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20140824_095656.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H02_Hyderabad_240814.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "16 Feb 2014",
            //        Location = "Mumbai",
            //        TimeTaken = "02:26:24",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20140216_044356.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/H01_Mumbai_160214.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "27 Nov 2016",
            //        Location = "Hyderabad",
            //        TimeTaken = "00:57:49",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20161127_060927.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/10k03_Hyderabad_27nov16.pdf{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "30 March 14",
            //        Location = "Pune",
            //        TimeTaken = "00:50:00",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20140330_095438.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/10k02_Pune_30mar14.png{1}", BlobURL, SASToken)
            //    },
            //    new Marathon()
            //    {
            //        Date = "01 Dec 2013",
            //        Location = "Pune",
            //        TimeTaken = "00:54:10",
            //        Div01 = string.Format("{0}/images/Marathon/IMG_20131201_084028.jpg{1}", BlobURL, SASToken),
            //        Div02 = string.Format("{0}/images/Marathon/10k01_Pune_01dec13.pdf{1}", BlobURL, SASToken)
            //    }
            //};

        }

        //private List<Timeline> GetFiles(string folderId)
        //{
        //    var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
        //    CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        //    var FileList = provider.GetDirectoryContents(Path.Combine("images", "PersonalProfile", folderId));
        //    List<Timeline> OutputData = new List<Timeline>();
        //    //var INFiles = INImages.OrderByDescending(m => m.Name);

        //    foreach (var item in FileList.OrderByDescending(m => m.Name).ToList())
        //    {
        //        string[] fileinfo = item.Name.Split('_');
        //        OutputData.Add(new Timeline()
        //        {
        //            Date = DateTime.ParseExact(fileinfo[1], "yyyyMMdd", cultureInfo).ToString("MMM yyyy"),
        //            DateInt = Convert.ToInt32(fileinfo[1]),
        //            Location = fileinfo.Last()[0..^4],
        //            Div01 = Path.Combine("images/PersonalProfile", folderId, item.Name)
        //        });
        //    }

        //    return OutputData;
        //}

        //private PersonalProfilePage GetProfilePageSection(string sectionId, string title, string folderId)
        //{
        //    var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
        //    CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        //    var FileList = provider.GetDirectoryContents(Path.Combine("images", "PersonalProfile", folderId));

        //    PersonalProfilePage outputData = new PersonalProfilePage()
        //    {
        //        SectionId = sectionId,
        //        PageTitle = title
        //    };

        //    foreach (var item in FileList.OrderByDescending(m => m.Name).ToList())
        //    {
        //        string[] fileinfo = item.Name.Split('_');
        //        outputData.SectionFiles.Add(new Timeline()
        //        {
        //            Date = DateTime.ParseExact(fileinfo[1], "yyyyMMdd", cultureInfo).ToString("MMM yyyy"),
        //            DateInt = Convert.ToInt32(fileinfo[1]),
        //            Location = fileinfo.Last()[0..^4],
        //            Div01 = Path.Combine("images/PersonalProfile", folderId, item.Name)
        //        });
        //    }

        //    return outputData;
        //}

        //public async Task<PersonalProfilePage> GetFilesFromStorage(string sectionId, string title, string folderId)
        //{
        //    CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        //    PersonalProfilePage outputData = new PersonalProfilePage()
        //    {
        //        SectionId = sectionId,
        //        PageTitle = title
        //    };
        //    try
        //    {
        //        var connectionString = new Uri(Path.Combine(BlobURL + SASToken));
        //        var blobContainerClient = new BlobContainerClient(connectionString);
        //        //List<string> blobNames = new List<string>();

        //        //if you want metadata set BlobTraits - BlobTraits.Metadata
        //        var blobs = blobContainerClient.GetBlobsAsync(BlobTraits.Metadata, BlobStates.None, prefix: folderId);

        //        await foreach (var blob in blobs)
        //        {
        //            string[] filename = blob.Name.Split('/');
        //            string[] fileinfo = filename.Last().Split('_');


        //            outputData.SectionFiles.Add(new Timeline()
        //            {
        //                Date = DateTime.ParseExact(fileinfo[1], "yyyyMMdd", cultureInfo).ToString("MMM yyyy"),
        //                DateInt = Convert.ToInt32(fileinfo[1]),
        //                Location = fileinfo.Last()[0..^4],
        //                Div01 = string.Format("{0}/{1}{2}", BlobURL, blob.Name, SASToken)
        //            });
        //            //blobNames.Add(blob.Name);
        //        }
        //    }
        //    catch (RequestFailedException e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.ReadLine();
        //        throw;
        //    }
        //    return outputData;
        //}
    }
}
