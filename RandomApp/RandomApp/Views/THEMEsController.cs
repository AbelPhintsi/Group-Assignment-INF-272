using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RandomApp.Models;

namespace RandomApp.Views
{
    public class THEMEsController : Controller
    {
        private DatabaseRandomEntities db = new DatabaseRandomEntities();

        // GET: THEMEs
        public ActionResult Index()
        {
            var tHEMEs = db.THEMEs.Include(t => t.Subject);
            return View(tHEMEs.ToList());
        }

        // GET: THEMEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THEME tHEME = db.THEMEs.Find(id);
            if (tHEME == null)
            {
                return HttpNotFound();
            }
            return View(tHEME);
        }

        // GET: THEMEs/Create
        public ActionResult Create()
        {
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectText");
            return View();
        }

        // POST: THEMEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThemeID,SubjectID,ThemeMode")] THEME tHEME)
        {
            if (ModelState.IsValid)
            {
                db.THEMEs.Add(tHEME);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectText", tHEME.SubjectID);
            return View(tHEME);
        }

        // GET: THEMEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THEME tHEME = db.THEMEs.Find(id);
            if (tHEME == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectText", tHEME.SubjectID);
            return View(tHEME);
        }

        // POST: THEMEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThemeID,SubjectID,ThemeMode")] THEME tHEME)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHEME).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectText", tHEME.SubjectID);
            return View(tHEME);
        }

        // GET: THEMEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THEME tHEME = db.THEMEs.Find(id);
            if (tHEME == null)
            {
                return HttpNotFound();
            }
            return View(tHEME);
        }

        // POST: THEMEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            THEME tHEME = db.THEMEs.Find(id);
            db.THEMEs.Remove(tHEME);
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
