using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.Main
{
    //[Authorize(Policy = "Country")]
    [Authorize(Policy = "Credit")]

    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string Type { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Type = "None";
        }
        public void OnGetIran()
        {
            Type = "Iran";
        }
        public void OnGetAfghanistan()
        {
            Type = "Afghanistan";
        }
    }

}
