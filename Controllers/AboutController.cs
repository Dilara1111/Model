using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using System;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            List<Cards> cards = new List<Cards>
            {
                new Cards {Id=1,FilePath = "display-4 bx bxs-bulb text-light",Title="Our Vision", Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra.\r\n"}
            };
            return View();
        }
    }
}
