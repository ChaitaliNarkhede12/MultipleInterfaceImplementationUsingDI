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
    }
}
