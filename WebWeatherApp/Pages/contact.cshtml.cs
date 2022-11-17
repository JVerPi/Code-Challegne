using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;

namespace WebWeatherApp.Pages
{
    public class InformationModel : PageModel
    {
        //private readonly ILogger<PrivacyModel> _logger;

        public Dictionary<string, string>[] informations { get; set; }


        public InformationModel(ILogger<InformationModel> logger)
        {
            //_logger = logger;

            informations = new Dictionary<string, string>[6];
        }

        public void OnGet()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");

            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            informations[0] = new Dictionary<string, string>() { { "name", "Datum" },       { "info", string.Format("{0:yyyy-MM-dd}", DateTime.Now) } };
            informations[1] = new Dictionary<string, string>() { { "name", "Version" },     { "info", string.Format("v{0}",currentVersion) } };
            informations[2] = new Dictionary<string, string>() { { "name", "Author" },      { "info", "Jesús Vergara" } };
            informations[3] = new Dictionary<string, string>() { { "name", "E-Mail" },      { "info", "jlvpino@gmail.com" } };
            informations[4] = new Dictionary<string, string>() { { "name", "Telefon" },     { "info", "+49 0157 38619962" } };            
            informations[5] = new Dictionary<string, string>() { { "name", "Job" },         { "info", "SW Developper" } };           

        }
    }
}