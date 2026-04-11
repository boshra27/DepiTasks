using ASP.NET02.Models;
using ASP.NET02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult ShowAll(int page =1)
        {
            int pageSize = 5;

            var depts = departmentBL.GetPaged(page, pageSize);
            int totalCount =departmentBL.GetCount();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            return View(nameof(ShowAll),depts);
        }

        public IActionResult ShowDetails(int id)
        {
            Departments Dept = departmentBL.GetById(id);
            return View(nameof(ShowDetails),Dept);
        }

        public IActionResult ShowDetailsVM(int id) 
        {   
            Departments Dept = departmentBL.GetById(id);

            DeptWithExtraInfoViewModel DVM = new DeptWithExtraInfoViewModel();
            DVM.DeptName = Dept.Name;
            DVM.StuNames = Dept.Students
                               .Where(s => s.Age > 25)
                               .Select((s) => s.Name)
                               .ToList();

            DVM.State = Dept.Students.Count > 50 ? "Main" : "Branch";

            return View(nameof(ShowDetailsVM),DVM);
        }

        public IActionResult Add()
        {
            return View(nameof(Add));
        }

        [HttpPost]
        public IActionResult SaveAdd(Departments DeptSent)
        {
            if(ModelState.IsValid)
            {
                departmentBL.AddDept(DeptSent);
                return RedirectToAction(nameof(ShowAll));
            }
            return View(nameof(Add), DeptSent);
        }

        public IActionResult Edit(int id)
        {
            Departments dept = departmentBL.GetById(id);

            return View(nameof(Edit),dept);
        }

        [HttpPost]
        public IActionResult SaveEdit(Departments NewDept, int id) 
        { 
            Departments OldDept = departmentBL.GetById(id);
            if(ModelState.IsValid)
            {
                OldDept.Id = NewDept.Id;
                OldDept.Name = NewDept.Name;
                OldDept.MgrName = NewDept.MgrName;
                departmentBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            return View(nameof(Edit), NewDept);
        }
    }
}
