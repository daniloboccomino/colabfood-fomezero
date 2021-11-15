using System;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class DonationController : Controller
    {
        public DonationController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
