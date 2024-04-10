using Microsoft.AspNetCore.Mvc;
using Test.Models;
using System.Linq;

namespace Test.Controllers
{
    public class UczenController : Controller
    {
        private static readonly List<Uczen> uczenList = new List<Uczen>(); // Lista uczniów

        public IActionResult Form()
        {
            return View(new Uczen());
        }

        [HttpPost]
        public IActionResult Form(Uczen uczen)
        {
            if (ModelState.IsValid)
            {
                if (uczenList.Any(u => u.Id == uczen.Id))
                {
                    ModelState.AddModelError("Id", "Student z takim ID już istnieje.");
                    return View(uczen);
                }

                uczenList.Add(uczen); // Dodajemy ucznia do listy
                return RedirectToAction("Index"); // Przekierowanie do widoku z listą
            }
            return View(uczen);
        }

        public IActionResult Index()
        {
            return View(uczenList); // Przekazujemy listę uczniów do widoku
        }
    }
}
