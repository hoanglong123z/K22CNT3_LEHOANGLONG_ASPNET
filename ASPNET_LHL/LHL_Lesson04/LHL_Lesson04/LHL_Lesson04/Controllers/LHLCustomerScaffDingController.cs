using LHL_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHL_Lesson04.Controllers
{
    public class LHLCustomerScaffDingController : Controller
    {

        private static List<LHLCustomer> listCustomer = new List<LHLCustomer>()
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
        // GET: LHLCustomerScaffDing
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult LHLCreate()
        {
            var model = new LHLCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult LHLCreate(LHLCustomer model)
        {
            listCustomer.Add(model);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult LHLEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}