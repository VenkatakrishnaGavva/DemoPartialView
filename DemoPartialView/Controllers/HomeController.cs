using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoPartialView.Models;

namespace DemoPartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult ShowNamesPopup()
        {
            List<PersonModel> persons = new List<PersonModel>
            {
                new PersonModel { Name ="Abc"},
                new PersonModel{ Name="xyz"}

            };
            return PartialView("ShowNamesPopup", persons);
        }
    }
}
