using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebWeatherApp.Pages
{
    public class WeahterModel : PageModel
    {
        private readonly ILogger<WeahterModel> _logger;

        public WeahterModel(ILogger<WeahterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}