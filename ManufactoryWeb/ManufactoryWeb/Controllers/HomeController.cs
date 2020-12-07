using ManufactoryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ManufactoryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            List<Manufactory> manufactories = new List<Manufactory>();
            manufactories = Helper.ApiHelper<List<Manufactory>>.HttpGetAsync("api/manufactory/gets");
            return View(manufactories);
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateManufactory model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateManufactoryResult();
                result = Helper.ApiHelper<CreateManufactoryResult>.HttpPostAsync("api/manufactory/create", "POST", model);
                if (result.ManufactoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(UpdateManufactory model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateManufactoryResult();
                result = Helper.ApiHelper<UpdateManufactoryResult>.HttpPostAsync("api/manufactory/update", "POST", model);
                if (result.ManufactoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(DeleteManufactory model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteManufactoryResult();
                result = Helper.ApiHelper<DeleteManufactoryResult>.HttpPostAsync("api/manufactory/delete", "DELETE", model);
                
                if (result.ManufactoryId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }
    }
}
