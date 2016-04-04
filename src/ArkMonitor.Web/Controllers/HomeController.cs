using ArkMonitor.Service;
using ArkMonitor.ViewModels;
using Microsoft.AspNet.Mvc;
using System.Reflection;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ArkMonitor.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArkService _arkService;

        public HomeController(IArkService arkService)
        {
            _arkService = arkService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel();

            var config = _arkService.GetArkServerConfiguration();

            config.GameUserSettings.ServerSettings.ServerAdminPassword = null;
            config.GameUserSettings.ServerSettings.ServerPassword = null;
            config.GameUserSettings.ServerSettings.SpectatorPassword = null;

            viewModel.ServerName = config.GameUserSettings.SessionSettings.SessionName;

            foreach (var prop in typeof (ServerSettings).GetProperties())
            {
                var val = prop.GetValue(config.GameUserSettings.ServerSettings, null);
                if (val != null)
                    viewModel.Configuration.Add(prop.Name, val.ToString());
            }

            return View(viewModel);
        }
    }
}