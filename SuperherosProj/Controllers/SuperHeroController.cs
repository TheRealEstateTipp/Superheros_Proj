using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperherosProj.Data;
using SuperherosProj.Models;

namespace SuperherosProj.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var superheroes = _context.Superheroes.ToList();
            return View(superheroes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Superhero superhero)
        {
            _context.Superheroes.Add(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var superhero = _context.Superheroes.Where(s => s.ID == id).SingleOrDefault();
            return View(superhero);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            var superhero = _context.Superheroes.Where(s => s.ID == id).SingleOrDefault();
            _context.Superheroes.Update(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var superhero = _context.Superheroes.Where(s => s.ID == id).SingleOrDefault();
            _context.Superheroes.Remove(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
