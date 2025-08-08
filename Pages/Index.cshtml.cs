using az_net_webapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace az_net_webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppSettings _settings;

        public string EnvironmentName { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IOptions<AppSettings> settings)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public void OnGet()
        {
            EnvironmentName = _settings.Environment;


        }
    }
}
