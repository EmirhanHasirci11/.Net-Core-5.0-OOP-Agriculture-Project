using AgriculturePresentation.Models;
using BuisnessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel p)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Insert(new Service()
                {

                    Description = p.Description,
                    Title = p.Title,
                    Image = p.Image
                });
                return RedirectToAction("Index", "Service");
            }
            else
            {
                return View();
            }

        }
        public IActionResult DeleteService(int id)
        {
            var service = _serviceService.GetById(id);
            _serviceService.Delete(service);
            return RedirectToAction("Index", "Service");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            //doğru değil denemek için yaptım
            var value = _serviceService.GetById(id);
           
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateService(Service p)
        {
            _serviceService.Update(p);
            return RedirectToAction("Index", "Service");

        }
    }
}
