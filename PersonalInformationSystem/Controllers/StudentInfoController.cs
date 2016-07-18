using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalInformationSystem.Models;
using PersonalInformationSystem.Providers;


namespace PersonalInformationSystem.Controllers
{
    public class StudentInfoController : Controller
    {
        StudentInfoProvider pro = new StudentInfoProvider();
        // GET: StudentInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(StudentInfoModel model)
        {
            pro.GetList(model);
            return View(model);
        }
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentInfoModel model)
        {
            
                pro.Save(model);
                return RedirectToAction("Index","Home");
            
            
           // return View(model);
        }
    }
}