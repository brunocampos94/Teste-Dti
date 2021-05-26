using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDti.Models;

namespace TesteDti.Controllers
{
    public class CompaniesController : Controller
    {
        public IActionResult Index()
        {
            List<Company> list = new List<Company>();

            list.Add(new Company(0, "A", 1.0));
            list.Add(new Company(1, "B", 0.7));
            list.Add(new Company(2, "C", 1.5));
            list.Add(new Company(3,  "D", 0.5));

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company company)
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            return RedirectToAction(nameof(Index));
        }

    }
}