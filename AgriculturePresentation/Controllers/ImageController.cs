using BuisnessLayer.Abstract;
using BuisnessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image p)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _imageService.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteImage(int id)
        {
            var image = _imageService.GetById(id);
            _imageService.Delete(image);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var image = _imageService.GetById(id);
            return View(image);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image p)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _imageService.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
