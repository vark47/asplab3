using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = FakeRepo.SharedRepository;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Your application description page.";

            return View("History");
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        public IActionResult Contact() => View(Repository.Stories);

        [HttpGet]
        public IActionResult AddStory() => View(new Story());

        [HttpPost]
        public IActionResult AddStory(Story s)
        {
            Repository.AddStory(s);
            return RedirectToAction("Index");
        }
    }
}
