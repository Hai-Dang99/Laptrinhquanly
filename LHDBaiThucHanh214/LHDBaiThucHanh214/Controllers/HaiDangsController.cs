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
    public class HaiDangsController : Controller
    {
        private LTQLdBcontext db = new LTQLdBcontext();

        // GET: HaiDangs
        public ActionResult Index()
        {
            return View(db.HaiDangs.ToList());
        }

        // GET: HaiDangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HaiDang haiDang = db.HaiDangs.Find(id);
            if (haiDang == null)
            {
                return HttpNotFound();
            }
            return View(haiDang);
        }

        // GET: HaiDangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HaiDangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HaiDangID,HaiDangName")] HaiDang haiDang)
        {
            if (ModelState.IsValid)
            {
                db.HaiDangs.Add(haiDang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(haiDang);
        }

        // GET: HaiDangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HaiDang haiDang = db.HaiDangs.Find(id);
            if (haiDang == null)
            {
                return HttpNotFound();
            }
            return View(haiDang);
        }

        // POST: HaiDangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HaiDangID,HaiDangName")] HaiDang haiDang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(haiDang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(haiDang);
        }

        // GET: HaiDangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HaiDang haiDang = db.HaiDangs.Find(id);
            if (haiDang == null)
            {
                return HttpNotFound();
            }
            return View(haiDang);
        }

        // POST: HaiDangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HaiDang haiDang = db.HaiDangs.Find(id);
            db.HaiDangs.Remove(haiDang);
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
