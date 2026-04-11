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
        public IActionResult ShowAll(int page = 1)
        {
            int pageSize = 5;
            var students = studentsBL.GetPaged(page, pageSize);
            int totalCount = studentsBL.GetCount();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            return View(nameof(ShowAll), students);
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
        public IActionResult SaveAdd(StudentWithDeptsViewModel StuVM)
        {
            if(ModelState.IsValid)
            {
                Students stu = new Students()
                {
                    Name = StuVM.Name,
                    Age = StuVM.Age,
                    DepartmentId = StuVM.DepartmentId
                };
                studentsBL.AddEmp(stu);
                return RedirectToAction(nameof(ShowAll));
            }
            StuVM.Departments = departmentBL.GetAll();
            return View(nameof(Add), StuVM);
        }

        public IActionResult Edit(int id)
        {
            Students student = studentsBL.GetById(id);
            List<Departments> DeptList = departmentBL.GetAll();
            StudentWithDeptsViewModel StuVM = new StudentWithDeptsViewModel()
            {
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,

                Departments = DeptList
            };
            return View(nameof(Edit), StuVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(StudentWithDeptsViewModel NewStuVM, int id)
        {
            Students OldStu = studentsBL.GetById(id);
            if(ModelState.IsValid)
            {
                OldStu.Id = NewStuVM.Id;
                OldStu.Name = NewStuVM.Name;
                OldStu.Age = NewStuVM.Age;
                OldStu.DepartmentId = NewStuVM.DepartmentId;
                studentsBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            NewStuVM.Departments = departmentBL.GetAll();
            return View(nameof(Edit), NewStuVM);
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
