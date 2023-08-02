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
        public ActionResult Details(int id)
        {
            CraftCourse thisCraftCourse = _db.CraftCourses
            .Include(craftCourse => craftCourse.Supplies)
            .ThenInclude(supply => supply.JoinEntities)
            .Include(craftCourse => craftCourse.Students)
            .ThenInclude(student => student.JoinEntities)
            .FirstOrDefault(craftCourse => craftCourse.CraftCourseId == id);

            return View(thisCraftCourse);
        }
         public ActionResult Edit(int id)
            {
                CraftCourse thisCraftCourse = _db.CraftCourses.FirstOrDefault(craftCourse => craftCourse.CraftCourseId == id);
                return View(thisCraftCourse);
            }
        [HttpPost]
            public ActionResult Edit(CraftCourse craftCourse)
            {
                _db.CraftCourses.Update(craftCourse);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        public ActionResult Delete(int id)
        {
            CraftCourse thisCraftCourse = _db.CraftCourse.FirstOrDefault(craftcourse => craftcourse.CraftCourseId == id);
            return View(thisCraftCourse);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CraftCourse this CraftCourse = _db.CraftCourse.FirstOrDefault(craftCourse => craftCourse.CraftCourseId == id);
            _db.CraftCourse.Remove(thisCraftCourse);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}