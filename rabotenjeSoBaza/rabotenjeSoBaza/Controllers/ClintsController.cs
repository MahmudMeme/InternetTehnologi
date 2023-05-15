using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rabotenjeSoBaza.Models;

namespace rabotenjeSoBaza.Controllers
{
    public class ClintsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clints
        public ActionResult Index()
        {
            return View(db.ClintDB.ToList());
        }

        // GET: Clints/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clint clint = db.ClintDB.Find(id);
            if (clint == null)
            {
                return HttpNotFound();
            }
            return View(clint);
        }

        // GET: Clints/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clints/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Age,Name,Address,Phone,ClientCard")] Clint clint)
        {
            if (ModelState.IsValid)
            {
                db.ClintDB.Add(clint);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clint);
        }

        // GET: Clints/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clint clint = db.ClintDB.Find(id);
            if (clint == null)
            {
                return HttpNotFound();
            }
            return View(clint);
        }

        // POST: Clints/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Age,Name,Address,Phone,ClientCard")] Clint clint)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clint).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clint);
        }

        // GET: Clints/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clint clint = db.ClintDB.Find(id);
            if (clint == null)
            {
                return HttpNotFound();
            }
            return View(clint);
        }

        // POST: Clints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clint clint = db.ClintDB.Find(id);
            db.ClintDB.Remove(clint);
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
