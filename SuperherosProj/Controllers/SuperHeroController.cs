using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperherosProj.Data;
using SuperherosProj.Models;

namespace SuperherosProj.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
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


    }
}
