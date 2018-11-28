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
        private string _currentUser;
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

            _currentUser = userName;
            _reminderService.CreateUser(userName, emailAddress, "1", password, null);

            //this wil redirect afet creation of account
            return RedirectToAction("selectReminder", "Home", null);
        }

        public IActionResult selectReminder()
        {
            //Still a work in progress getting list of reminders over
            var reminderList = _reminderService.Display();

            return View(reminderList);
        }

        [HttpPost]
        public JsonResult getGenres([FromBody]string data)
        {
            var allGeneres = _reminderService.GetRemindersMap();
            List<string> specificGenres = new List<string>();
            foreach (var x in allGeneres)
            {
                if (x.Key.ToString() == data)
                {
                    foreach (var y in x.Value.Keys)
                    {
                        specificGenres.Add(y.ToString());
                        ;
                    }
                }
            }
            return Json(specificGenres);
        }

        [HttpPost]
        public JsonResult reminderSubmission(IList<string> values) //Mr. Scott the values being returned here are the titles from submitting!!!
        {
            var result = _reminderService.AddReminderToUser(_currentUser, values);
            return Json("test"); //just returning something so ajax can use a success function

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
