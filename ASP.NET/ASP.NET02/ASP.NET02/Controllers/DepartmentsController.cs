using ASP.NET02.Models;
using ASP.NET02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult ShowAll()
        {   
            List<Departments> Depts =departmentBL.GetAll();
            return View(nameof(ShowAll),Depts);
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
            if(DeptSent.Name != null)
            {
                departmentBL.AddDept(DeptSent);
                return RedirectToAction(nameof(ShowAll));
            }
            return View(nameof(Add), DeptSent);
        }
    }
}
