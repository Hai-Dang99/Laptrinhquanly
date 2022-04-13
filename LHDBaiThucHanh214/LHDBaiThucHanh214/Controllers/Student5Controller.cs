using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LHDBaiThucHanh214.Models;

namespace LHDBaiThucHanh214.Controllers
{
    public class Student5Controller : Controller
    {
        private LTQLdBcontext db = new LTQLdBcontext();

        // GET: Student5
        public ActionResult Index()
        {
            return View(db.Student5s.ToList());
        }

        // GET: Student5/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student5 student5 = db.Student5s.Find(id);
            if (student5 == null)
            {
                return HttpNotFound();
            }
            return View(student5);
        }

        // GET: Student5/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student5/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Student5ID,Student5Name")] Student5 student5)
        {
            if (ModelState.IsValid)
            {
                db.Student5s.Add(student5);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student5);
        }

        // GET: Student5/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student5 student5 = db.Student5s.Find(id);
            if (student5 == null)
            {
                return HttpNotFound();
            }
            return View(student5);
        }

        // POST: Student5/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Student5ID,Student5Name")] Student5 student5)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student5).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student5);
        }

        // GET: Student5/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student5 student5 = db.Student5s.Find(id);
            if (student5 == null)
            {
                return HttpNotFound();
            }
            return View(student5);
        }

        // POST: Student5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student5 student5 = db.Student5s.Find(id);
            db.Student5s.Remove(student5);
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
