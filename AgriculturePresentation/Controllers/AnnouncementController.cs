using BuisnessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var announcements = _announcementService.GetListAll();
            return View(announcements);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p)
        {
            p.Status = true;
            p.Date =DateTime.Parse(DateTime.Now.ToShortDateString());
            _announcementService.Insert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var announcement = _announcementService.GetById(id);
            _announcementService.Delete(announcement);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var announcement = _announcementService.GetById(id);
            return View(announcement);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement p)
        {

            _announcementService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }


    }
}
