using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //private IMessenger iMessenger;

        //public HomeController(Func<CommunicationType, IMessenger> serviceResolver)
        //{
        //    this.iMessenger = serviceResolver(CommunicationType.Email);
        //}
        //public IActionResult Index()
        //{
        //    string str = this.iMessenger.SendMessage();
        //    ViewBag.Msg = str;
        //    return View();
        //}

        private readonly IEnumerable<IMessenger> iMessengers;
        public HomeController(IEnumerable<IMessenger> _iMessenger)
        {
            this.iMessengers = _iMessenger;
        }
        public IActionResult Index()
        {
            var messenger = iMessengers.FirstOrDefault(h => h.CurrentName == CommunicationType.Email.ToString());
            string str = messenger?.SendMessage();
            ViewBag.Msg = str;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
