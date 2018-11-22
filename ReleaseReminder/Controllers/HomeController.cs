using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        //Below will pull users info from forums
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            string userName = formCollection["userName"];
            string emailAddress = formCollection["email"];
            string password = formCollection["password"];
            
            //this wil redirect afet creation of account
            return RedirectToAction("Forms", "Home", null);
        }

        public IActionResult Forms()
        {
            //Still a work in progress getting list of reminders over
            var reminderList = _reminderService.Display();
            var test = _reminderService.GetRemindersMap();

            return View(reminderList);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
