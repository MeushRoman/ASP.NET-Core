using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Abstracts;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConnection _connection;

        public HomeController(IConnection connection)
        {
            _connection = connection;
        }

        public IActionResult Index()
        {
            ViewBag.Con = _connection.GetConnection();


            return View();
        }

        public IActionResult About([FromServices] IMessage msg)
        {
            ViewData["Message"] = msg.Send("text");

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

        public IActionResult Test(string name)
        {
            return Ok("hello" + name);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
