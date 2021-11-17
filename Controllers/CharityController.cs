using System;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class CharityController : Controller
    {
        private ICharityRepository _charityRepository;

        public CharityController(ICharityRepository charityRepository)
        {
            _charityRepository = charityRepository;
        }

        public IActionResult Index(int id)
        {
            return View(_charityRepository.FindById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Charity charity)
        {
            _charityRepository.Create(charity);
            _charityRepository.Save();
            TempData["msg"] = "ONG cadastrada";
            return RedirectToAction("Index", charity.CharityId);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_charityRepository.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Charity charity)
        {
            return RedirectToAction("Index", charity.CharityId);
        }
    }
}
