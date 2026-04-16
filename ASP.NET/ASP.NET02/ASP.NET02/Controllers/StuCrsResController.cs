using ASP.NET02.Models;
using ASP.NET02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class StuCrsResController: Controller
    {
        StuCrsResBL stuCrsResBL = new StuCrsResBL();

        public IActionResult Details(int sid, int cid)
        {
            StuCrsRes scr= stuCrsResBL.GetById(sid,cid);
            StuCrsResViewModel scrVM = new StuCrsResViewModel()
            {
                StudentName = scr.Student.Name,
                CourseName = scr.Course.Name,
                Grade = scr.Grade,
                Color = scr.Grade >= 50 ? "green" : "red"
            };
            return View(nameof(Details), scrVM);
        }
    }
}
