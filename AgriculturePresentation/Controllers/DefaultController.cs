using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.GetListAll();
            return View(values);
        }
        public IActionResult LayoutTry()
        {
            return View();
        }
    }
}
