using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LHL_Lesson06_Entity_FrameWork.Models;

namespace LHL_Lesson06_Entity_FrameWork.Controllers
{
    public class LHLBooksController : Controller
    {
        private LhlBookStore db = new LhlBookStore();

        // GET: LHLBooks
        public ActionResult Index()
        {
            return View(db.LHLCBooks.ToList());
        }

        // GET: LHLBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LHLBook lHLBook = db.LHLCBooks.Find(id);
            if (lHLBook == null)
            {
                return HttpNotFound();
            }
            return View(lHLBook);
        }

        // GET: LHLBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LHLBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LhlId,LhlBookId,LhlTitle,LhlAuthor,LhlYear,LhlPulisher,LhlPicture,LhlCategoryId")] LHLBook lHLBook)
        {
            if (ModelState.IsValid)
            {
                db.LHLCBooks.Add(lHLBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lHLBook);
        }

        // GET: LHLBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LHLBook lHLBook = db.LHLCBooks.Find(id);
            if (lHLBook == null)
            {
                return HttpNotFound();
            }
            return View(lHLBook);
        }

        // POST: LHLBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LhlId,LhlBookId,LhlTitle,LhlAuthor,LhlYear,LhlPulisher,LhlPicture,LhlCategoryId")] LHLBook lHLBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lHLBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lHLBook);
        }

        // GET: LHLBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LHLBook lHLBook = db.LHLCBooks.Find(id);
            if (lHLBook == null)
            {
                return HttpNotFound();
            }
            return View(lHLBook);
        }

        // POST: LHLBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LHLBook lHLBook = db.LHLCBooks.Find(id);
            db.LHLCBooks.Remove(lHLBook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
