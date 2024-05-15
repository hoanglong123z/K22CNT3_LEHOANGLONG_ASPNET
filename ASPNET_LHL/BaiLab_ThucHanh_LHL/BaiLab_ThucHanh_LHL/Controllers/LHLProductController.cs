using BaiLab_ThucHanh_LHL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiLab_ThucHanh_LHL.Controllers
{
    public class LHLProductController : Controller
    {
        private static List<LHLProduct> _products = new List<LHLProduct>
        {
            new LHLProduct { ProductId = "P001", ProductName = "Ram DDR4 16GB", Unit = "3200", Price = 1500000 },
            new LHLProduct { ProductId = "P002", ProductName = "Ram DDR4 32GB", Unit = "3200", Price = 3000000 },
            new LHLProduct { ProductId = "P003", ProductName = "Ram DDR4 8GB", Unit = "3200", Price = 650000 }
        };
        // GET: LHLProduct
        public ActionResult Index()
        {
            return View(_products);
        }
        public ActionResult Create()
        {
            return View();
        }

        // Action để xử lý thêm sản phẩm
        [HttpPost]
        public ActionResult Create(LHLProduct product)
        {
            _products.Add(product);
            return RedirectToAction("Index");
        }

        // Action để hiển thị form sửa sản phẩm
        public ActionResult Edit(string id)
        {
            LHLProduct product = _products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // Action để xử lý sửa sản phẩm
        [HttpPost]
        public ActionResult Edit(LHLProduct product)
        {
            LHLProduct existingProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.Unit = product.Unit;
                existingProduct.Price = product.Price;
            }
            return RedirectToAction("Index");
        }

        // Action để hiển thị form xác nhận xóa sản phẩm
        public ActionResult Delete(string id)
        {
            LHLProduct product = _products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // Action để xử lý xóa sản phẩm
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            LHLProduct product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return RedirectToAction("Index");
        }

        // Action để tìm kiếm sản phẩm
        public ActionResult Search(string keyword)
        {
            List<LHLProduct> products = _products
                .Where(p => p.ProductName.Contains(keyword))
                .ToList();
            return View(products);
        }
    }
}