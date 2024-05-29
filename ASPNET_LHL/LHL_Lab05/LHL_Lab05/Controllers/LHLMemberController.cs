using LHL_Lab05.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHL_Lab05.Controllers
{
    public class LHLMemberController : Controller
    {
        // GET: LHLMember
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult lhlCreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult lhlCreateOne(LHLMember m)
        {
            return View("Details", m);
        }

        public ActionResult lhlCreateTwo()
        {
            return View();
        }
        [HttpPost]

        public ActionResult lhlCreateTwo(LHLMember m)
        {
            if (m.ID == null)
            {
                ViewBag.error = "Hãy Nhập mã số ";
                return View();
            }
            if (m.Username == null)
            {
                ViewBag.error = "Hãy Nhập mã số ";
                return View();
            }
            if (m.FullName == null)
            {
                    ViewBag.Error = "Hãy Nhập mã số ";
                    return View();
            }
            if(m.PassWord == null)
            {
                ViewBag.Error = "Hãy nhập Mật khẩu";
                return View();
            }
            if (m.Age == null)
            {
                    ViewBag.Error = "Hãy Nhập mã số ";
                    return View();
            }
                if (m.Email == null)
                {
                    ViewBag.Error = "Hãy Nhập mã số ";
                    return View();
                }
                string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-0.-]+\[A-Za-z]{2,4}";
                if (!System.Text.RegularExpressions.Regex.IsMatch(m.Email, regexPattern))
                {
                    ViewBag.Error = "Hãy Nhập Đúng Định Dạng";
                    return View();
                }
                return View("Details", m);
        }
        public ActionResult lhlCreateThree()
        {
            return View();
        }
        [HttpPost]
        public ActionResult lhlCreateThree(LHLMember m)
        {
            if(ModelState.IsValid)
                return View("Deatails",m);
            else
                return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}