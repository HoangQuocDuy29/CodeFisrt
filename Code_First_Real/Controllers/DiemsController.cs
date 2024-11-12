using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Code_First_Real.Models;

namespace Code_First_Real.Controllers
{
    public class DiemsController : Controller
    {
        private QLSVDataContext db = new QLSVDataContext();

        // GET: Diems
        public ActionResult Index()
        {
            var diems = db.diems.Include(d => d.SinhVien);
            return View(diems.ToList());
        }

        // GET: Diems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // GET: Diems/Create
        public ActionResult Create()
        {
            ViewBag.Masv = new SelectList(db.SinhViens, "Masv", "Hoten");
            return View();
        }

        // POST: Diems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masv,TenMH,DiemThi")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.diems.Add(diem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Masv = new SelectList(db.SinhViens, "Masv", "Hoten", diem.Masv);
            return View(diem);
        }

        // GET: Diems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            ViewBag.Masv = new SelectList(db.SinhViens, "Masv", "Hoten", diem.Masv);
            return View(diem);
        }

        // POST: Diems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Masv,TenMH,DiemThi")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Masv = new SelectList(db.SinhViens, "Masv", "Hoten", diem.Masv);
            return View(diem);
        }

        // GET: Diems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // POST: Diems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diem diem = db.diems.Find(id);
            db.diems.Remove(diem);
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
