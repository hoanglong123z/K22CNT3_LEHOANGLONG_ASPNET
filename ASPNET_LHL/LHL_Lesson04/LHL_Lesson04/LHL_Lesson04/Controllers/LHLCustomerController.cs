using LHL_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHL_Lesson04.Controllers
{
    public class LHLCustomerController : Controller
    {
        // GET: LHLCustomer
        public ActionResult Index()
        {
            return View();
        }

        //Action: LHLCustomerDetails
        public ActionResult LHLCustomerDetails()
        {
            //tạo đối tượng trong dữ liệu 
            var customer = new LHLCustomer()
            {
                CustomerID = 1,
                FirstName = "Lê Hoàng",
                LastName = "Long",
                Address = "K22CNT3",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult LHLlistCustomer()
        {
            var list = new List<LHLCustomer>()
            {
                new LHLCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Lê Hoàng",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LHLCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Ngô Hoàng",
                     LastName = "Minh",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LHLCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Lê Trần Khánh",
                     LastName = "Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LHLCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
            ViewBag.list = list;
            return View();
        }
    }
}