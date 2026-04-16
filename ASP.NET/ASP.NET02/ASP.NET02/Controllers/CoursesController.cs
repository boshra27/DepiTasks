using ASP.NET02.Models;
using ASP.NET02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class CoursesController : Controller
    {
        CoursesBL coursesBL = new CoursesBL();
        DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult ShowAll()
        {
            return View(nameof(ShowAll), coursesBL.GetAll());
        }

        public IActionResult Details(int id) 
        { 
            Courses courses = coursesBL.GetById(id);
            return View(nameof(Details),courses);
        }

        public IActionResult Add() 
        {
            CoursesWithDeptsViewModel CrsVM = new CoursesWithDeptsViewModel()
            {
                Departments = departmentBL.GetAll(),
            };
            return View(nameof(Add), CrsVM);
        }

        [HttpPost]
        public IActionResult SaveAdd(CoursesWithDeptsViewModel CrsVM)
        {
            if (ModelState.IsValid)
            {
                Courses Crs = new Courses()
                {
                    Name = CrsVM.Name,
                    Degree = CrsVM.Degree,
                    MinDegree = CrsVM.MinDegree,
                    DepartmentId = CrsVM.DepartmentId,
                };
                coursesBL.AddCourse(Crs);
                return RedirectToAction(nameof(ShowAll));
            }
            CrsVM.Departments = departmentBL.GetAll();
            return View(nameof(Add), CrsVM);
        }


        
        public IActionResult Edit(int id) 
        {
            Courses Crs = coursesBL.GetById(id);
            CoursesWithDeptsViewModel CrsVM = new CoursesWithDeptsViewModel()
            {
                Name = Crs.Name,
                Degree = Crs.Degree,
                MinDegree = Crs.MinDegree,
                DepartmentId = Crs.DepartmentId,

                Departments = departmentBL.GetAll(),
            };
            return View(nameof (Edit), CrsVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(CoursesWithDeptsViewModel NewCrsVM, int id)
        {
            Courses OldCrs = coursesBL.GetById(id);
            if (ModelState.IsValid) 
            {
                OldCrs.Name = NewCrsVM.Name;
                OldCrs.Degree = NewCrsVM.Degree;
                OldCrs.MinDegree = NewCrsVM.MinDegree;
                OldCrs.DepartmentId = NewCrsVM.DepartmentId;
                coursesBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            NewCrsVM.Departments = departmentBL.GetAll();
            return View(nameof(Edit), NewCrsVM);
        }

        public IActionResult Delete(int id) 
        {
            return View(nameof(Delete), coursesBL.GetById(id));
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Courses Crs = coursesBL.GetById(id);
            if(Crs != null)
            {
                coursesBL.DeleteCrs(Crs);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
        }
    }
}
