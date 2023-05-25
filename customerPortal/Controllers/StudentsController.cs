using BLL.LogicServices;
using BOL.CommonEntities;
using BOL.DataBaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace customerPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsLogic _StudentsLogic;
        public StudentsController(IStudentsLogic studentsLogic)
        {
            _StudentsLogic = studentsLogic;
        }

        [HttpGet]
        public IActionResult StudentsList()
        {
            StudentModules model = new StudentModules();
            model.StudentsList = _StudentsLogic.GetStudentsListLogic();
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateStudent()
        { 

            return View();
        }
        [HttpPost]
        public IActionResult CreateStudentPost(Students FormData)
        {
            string result = _StudentsLogic.saveStudentRecordLogic(FormData);
            if(result == "Saved Sucessfully")
            {
                return RedirectToAction("StudentsList","Students"); 
            }
            else
            {
                TempData["ErrorTemp"] = result;
                return RedirectToAction("CreateStudent", "Students");
            } 
        }
    }
}
