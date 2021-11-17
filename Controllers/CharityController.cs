using System;
using globalsolution.fomezero.Models;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class CharityController : Controller
    {
        public CharityController()
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
        public IActionResult Create(Charity charity)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Charity charity)
        {
            return RedirectToAction("Index");
        }
    }
}
