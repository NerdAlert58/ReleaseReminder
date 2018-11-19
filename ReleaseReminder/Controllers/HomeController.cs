using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ReleaseReminder.Models;

namespace ReleaseReminder.Controllers
{
    public class HomeController : Controller
    {
        private IReminderService _reminderService;
        public HomeController(IServiceProvider services)
        {
            var reminderService = (ReminderService)services.GetService(typeof(IReminderService));
            _reminderService = reminderService ?? throw new ArgumentNullException(nameof(reminderService));

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Forms()
        {

            var reminderList = _reminderService.Display();
        


            // ViewBag.reminderList = _reminderService.Display();
            return View(reminderList);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
