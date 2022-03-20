﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Interfaces;
using Restaurant.Business.Interfaces.Setting;
using Restaurant.Business.Services;
using Restaurant.Business.ViewModels;
using Restaurant.Business.ViewModels.Home.About;
using Restaurant.Core.Models;
using Restaurant.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.UI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class AboutOptionController : Controller
    {
        private IDeliciousService _deliciouseService;

        public AboutOptionController(IDeliciousService deliciousService)
        {
            _deliciouseService = deliciousService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.OptionCount = _deliciouseService.AboutOptionService.GetAll().Result.Count();
            var option = await _deliciouseService.AboutOptionService.GetAll();
            ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
            return View(option);
        }
        public IActionResult Create()
        {
            if (_deliciouseService.AboutOptionService.GetAll().Result.Count() == 3) return BadRequest();
            ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutOptionCreateVM aboutOptionCreate)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
                return View();
            }
            try
            {
                await _deliciouseService.AboutOptionService.Create(aboutOptionCreate);
            }
            catch (Exception)
            {
                ModelState.AddModelError("Option", "This Option is available");
                ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            AboutOptionUpdateVM aboutOption = await _deliciouseService.AboutOptionService.GetMap(id);
            ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
            return View(aboutOption);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, AboutOptionUpdateVM aboutOptionUpdate)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.RestaurantName = _deliciouseService.ReservationService.GetSetting("RestaurantName");
                return View();
            }
            try
            {
                await _deliciouseService.AboutOptionService.Update(id, aboutOptionUpdate);

            }
            catch (Exception)
            {
                ModelState.AddModelError("Option", "This Option is available");
                ViewBag.RestaurantName = _deliciouseService.AboutOptionService.GetSetting("RestaurantName");
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
           await _deliciouseService.AboutOptionService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
