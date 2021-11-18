using System;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace globalsolution.fomezero.Controllers
{
    public class AdvertisingController : Controller
    {
        private IAdvertisingRepository _advertisingRepository;
        private IProviderRepository _providerRepository;
        private ICharityRepository _charityRepository;

        public AdvertisingController(IAdvertisingRepository advertisingRepository, IProviderRepository providerRepository, ICharityRepository charityRepository)
        {
            _advertisingRepository = advertisingRepository;
            _providerRepository = providerRepository;
            _charityRepository = charityRepository;
        }

        public IActionResult Index()
        {
            var advertisings = _advertisingRepository.List();
            return View(advertisings);
        }

        [HttpGet]
        public IActionResult Create()
        {
            GetProviders();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Advertising advertising)
        {
            _advertisingRepository.Create(advertising);
            _advertisingRepository.Save();
            TempData["msg"] = "Anúncio cadastrado";
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

        private void GetProviders()
        {
            var providers = _providerRepository.List();
            ViewBag.providers = new SelectList(providers, "ProviderId", "Name");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            GetCharities();
            return View(_advertisingRepository.FindById(id));
        }

        private void GetCharities()
        {
            var charities = _charityRepository.List();
            ViewBag.charities = new SelectList(charities, "CharityId", "Name");
        }

        [HttpPost]
        public IActionResult Withdraw(int id, int quantity)
        {
            var advertising = _advertisingRepository.FindById(id);
            if (quantity > advertising.Quantity)
            {
                TempData["msg"] = "Quantidade para retirada é maior que a disponível";
                return RedirectToAction("Index");
            }
            else if (quantity == advertising.Quantity)
            {
                _advertisingRepository.Delete(id);
            }
            else
            {
                advertising.Quantity -= quantity;
                _advertisingRepository.Update(advertising);
            }
            _advertisingRepository.Save();
            TempData["msg"] = "Doação Retirada";
            return RedirectToAction("Index");
        }
    }
}
