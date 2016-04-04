using System.Collections.Generic;

namespace ArkMonitor.ViewModels
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Configuration = new Dictionary<string, string>();
        }
        public string ServerName { get; set; }

        public IDictionary<string, string> Configuration { get; set; }
    }
}