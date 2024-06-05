using LHL_Lesson06_Entity_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHL_Lesson06_Entity_FrameWork.Controllers
{
    public class LHLCategoriesController : Controller
    {
        private static LhlBookStore lhlDb;
        public LHLCategoriesController()
        {
            lhlDb = new LhlBookStore();
        }
        // GET: LHLCategories
        public ActionResult LhlIndex()
        {
            /*
            * Khởi tạo DbContext:
            * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET FreamWork trên máy 
            * và sau đó tạo csdl 
            * */
            LhlBookStore LhlDb = new LhlBookStore();
            var LhlCategories = LhlDb.LHLCategories.ToList();
            return View(LhlCategories);
        }
        public ActionResult LhlCreate()
        {
            var lhlcategory = new LHLCategory();
            return View(lhlcategory);
        }
        [HttpPost]
        public ActionResult LhlCreate(LHLCategory lHLCategory)
        {
            lhlDb.LHLCategories.Add(lHLCategory);
            lhlDb.SaveChanges();
            return RedirectToAction("LhlIndex");
        }
    }
}