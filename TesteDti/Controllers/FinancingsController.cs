using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDti.Models;

namespace TesteDti.Controllers
{
    public class FinancingsController : Controller
    {
        public IActionResult Index()
        {
            List<Financing> list = new List<Financing>();

            Company c1 = new Company(0, "A", 1.0);
            Company c2 = new Company(1, "B", 0.7);
            Company c3 = new Company(2, "C", 1.5);
            Company c4 = new Company(3, "D", 0.5);

            list.Add(new Financing(0, 10000, c1, 500, 10));
            list.Add(new Financing(1, 30000, c2, 500,  8));
            list.Add(new Financing(3,  5000, c3, 600, 12));
            list.Add(new Financing(4, 50000, c4, 350, 10));

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Financing financing)
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