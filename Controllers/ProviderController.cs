using System;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace globalsolution.fomezero.Controllers
{
    public class ProviderController : Controller
    {
        private IProviderRepository _providerRepository;

        public ProviderController(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public IActionResult Index(int id)
        {
            return View(_providerRepository.FindById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Provider provider)
        {
            _providerRepository.Create(provider);
            _providerRepository.Save();
            TempData["msg"] = "Fornecedor cadastrado";
            return RedirectToAction("Index", provider.ProviderId);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_providerRepository.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Provider provider)
        {
            return RedirectToAction("Index", provider.ProviderId);
        }
    }
}
