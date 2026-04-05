using ASP.NET02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentsBL studentsBL = new StudentsBL();
            List<Students> StuList = studentsBL.GetAll();
            return View(nameof(ShowAll), StuList);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentsBL studentsBL = new StudentsBL();
            Students student = studentsBL.GetById(id);
            return View(nameof(ShowDetails), student);

        }
    }
}
