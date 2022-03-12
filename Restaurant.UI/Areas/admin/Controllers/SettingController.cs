﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Business.Services;
using Restaurant.Business.ViewModels;
using Restaurant.Business.ViewModels.Setting;
using Restaurant.Core.Models;
using Restaurant.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.UI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private AppDbContext _context;
        private SettingServices _settingServices;

        public SettingController(AppDbContext context,
                                 SettingServices settingServices)
        {
            _context = context;
            _settingServices = settingServices; 
        }
        private int GetSetting(string key)
        {
            Dictionary<string, string> Settings = _settingServices.GetSetting();
            string value = Settings[$"{key}"];
            return int.Parse(value);
        }
        public IActionResult Index(int page=1)
        {
            int count = GetSetting("TakeCount");
            ViewBag.TakeCount = count;
            var settings = _context.Settings
                                   .Skip((page - 1) * count)
                                   .Take(count)
                                   .ToList();
            var settingVM = GetProductList(settings);
            int pageCount = GetPageCount(count);
            Paginate<SettingListVM> model = new Paginate<SettingListVM>(settingVM, page, pageCount);
            return View(model);
        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Settings.Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<SettingListVM> GetProductList(List<Setting> settings)
        {
            List<SettingListVM> model = new List<SettingListVM>();
            foreach (var item in settings)
            {
                var setting = new SettingListVM
                {
                    Id = item.Id,
                    Key=item.Key,
                    Value=item.Value,
                    Type = item.Type,
                };
                model.Add(setting);
            }
            return model;
        }
        public IActionResult Update(int id)
        {
            Setting setting = _context.Settings.Find(id);
            if (setting == null) return NotFound();
            ViewBag.Setting = setting.Key;
            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Setting setting)
        {
            if (!ModelState.IsValid) return View(setting);
            Setting dbSetting = await _context.Settings.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (dbSetting == null) return NotFound();
            dbSetting.Value = setting.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
