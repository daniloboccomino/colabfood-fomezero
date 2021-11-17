using System;
using globalsolution.fomezero.Models;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class ProviderController : Controller
    {
        public ProviderController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Provider provider)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Provider provider)
        {
            return RedirectToAction("Index");
        }
    }
}
