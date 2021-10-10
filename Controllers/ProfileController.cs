using FluentMyProfileApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FluentMyProfileApp.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ProfileVm profile)
        {
            if(!ModelState.IsValid)
            {
                return View(profile);
            }

            /* 
             *
             *  save functionality comes here 
             *
             */

            return View();
        }
    }
}