using ASP.NET02.Models;
using ASP.NET02.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class StudentsController : Controller
    {
        StudentsBL studentsBL = new StudentsBL();
        DepartmentBL departmentBL = new DepartmentBL();
        
        // GETALL()
        public IActionResult ShowAll()
        {
            return View(nameof(ShowAll), studentsBL.GetAll());
        }

        // GETBYID
        public IActionResult ShowDetails(int id)
        {
            Students student = studentsBL.GetById(id);
            return View(nameof(ShowDetails), student);
        }

        public IActionResult Add()
        {
            StudentWithDeptsViewModel StuVM = new StudentWithDeptsViewModel()
            {
                Departments = departmentBL.GetAll()
            };
            return View(nameof(Add), StuVM);
        }

        [HttpPost]
        public IActionResult SaveAdd(Students Stu)
        {
            if(Stu.Name != null && Stu.DepartmentId > 0)
            {
                studentsBL.AddEmp(Stu);
                return RedirectToAction(nameof(ShowAll));
            }
            return View(nameof(Add), Stu);
        }

        public IActionResult Edit(int id)
        {
            Students student = studentsBL.GetById(id);
            List<Departments> DeptList = departmentBL.GetAll();
            StudentWithDeptsViewModel StuVM = new StudentWithDeptsViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,

                Departments = DeptList
            };
            return View(nameof(Edit), StuVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(Students NewStu, int id)
        {
            Students OldStu = studentsBL.GetById(id);
            if(NewStu.Name != null)
            {
                OldStu.Id = NewStu.Id;
                OldStu.Name = NewStu.Name;
                OldStu.Age = NewStu.Age;
                OldStu.DepartmentId = NewStu.DepartmentId;
                studentsBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            return View(nameof(Edit), NewStu);
        }

        public IActionResult Delete(int id) 
        {
            return View(nameof(Delete), studentsBL.GetById(id));
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Students Stu = studentsBL.GetById(id);
            if(Stu != null)
            {
                studentsBL.DeleteStu(Stu);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
           
        }

    }
}
