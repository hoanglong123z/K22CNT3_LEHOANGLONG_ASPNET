using Lesson04_lab4_1_LHL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04_lab4_1_LHL.Controllers
{
    public class LHLCustomerController : Controller
    {
        // GET: LHLCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LHLCustomerDetails()
        {
            LHLCustomer cus = new LHLCustomer()
            {
                CustomerID = "001",
                CustomerName = "Lê Hoàng Long",
                CustomerPhone = "0349393995",
                CustomerAddress = "Hà Nội",
                CustomerEmail = "lehoanglong26072004@gmail.com",
                Balancelhl = 1520000
            };
            return View(cus);
        }
        public ActionResult LHLCustomerList()
        {
            List<LHLCustomer> listcustomer = new List<LHLCustomer>()
            {
                new LHLCustomer()
                {
                    CustomerID = "001",
                    CustomerName = "Lê Hoàng Long",
                    CustomerPhone = "0349393995",
                    CustomerAddress = "Hà Nội",
                    CustomerEmail = "lehoanglong26072004@gmail.com",
                    Balancelhl = 1520000
                },
                new LHLCustomer()
                {
                    CustomerID = "002",
                    CustomerName = "Ngô Hoàng Minh",
                    CustomerPhone = "0349393995",
                    CustomerAddress = "Hà Nội",
                    CustomerEmail = "aaaasvvs@gmail.com",
                    Balancelhl = 1520000
                },
                new LHLCustomer()
                {
                    CustomerID = "003",
                    CustomerName = "Lê Trần Khánh Duy",
                    CustomerPhone = "0349393995",
                    CustomerAddress = "Nam Định",
                    CustomerEmail = "asssvvff@gmail.com",
                    Balancelhl = 1520000
                }
            };
            ViewBag.list = listcustomer;
            return View();
        }
    }
}