using System;
using globalsolution.fomezero.Models;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class AdvertisingController : Controller
    {
        public AdvertisingController()
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
        public IActionResult Create(Advertising advertising)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Advertising advertising)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
