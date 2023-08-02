using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CraftU.Models;
using System.Collections.Generic;
using System.Linq;

namespace CraftU.Controllers
{
    public class CraftCoursesController : Controller
    {
        private readonly CraftUContext _db;
        public CraftCoursesController(CraftUContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<CraftCourse> model = _db.CraftCourses.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CraftCourse craftCourse)
        {
            _db.CraftCourses.Add(craftCourse);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details (int id)
        {
            CraftCourse thisCraftCourse = _db.CraftCourses
            .Include(supply => supply.JoinEntities)
            .FirstOrDefault(craftCourse => craftCourse.CraftCourseId == id);
            return View(thisCraftCourse);
        }
    }
}