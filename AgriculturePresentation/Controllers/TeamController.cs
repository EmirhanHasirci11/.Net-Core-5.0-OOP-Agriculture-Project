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
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team p)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {

                _teamService.Insert(p);
                return RedirectToAction("Index", "Team");
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
        public IActionResult DeleteTeam(int id)
        {
            var team = _teamService.GetById(id);
            _teamService.Delete(team);
            return RedirectToAction("Index", "Team");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var team = _teamService.GetById(id);
            return View(team);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team p)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {

                _teamService.Update(p);
                return RedirectToAction("Index", "Team");
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
