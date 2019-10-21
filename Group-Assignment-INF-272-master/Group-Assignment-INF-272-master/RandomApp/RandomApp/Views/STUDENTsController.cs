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
    public class STUDENTsController : Controller
    {
        private DatabaseRandomEntities db = new DatabaseRandomEntities();

        // GET: STUDENTs
        public ActionResult Index()
        {
            UserVM UserViewModel = TempData["UserViewModel"] as UserVM;

            if (UserViewModel.UserLoggedIn(db))
            {
                UserViewModel.RefreshGUID(db);
                StudentVM StudentVM = new StudentVM();
                StudentVM.UserViewModel = UserViewModel;
                StudentVM.students = db.STUDENTs.ToList();
                return View(StudentVM);
            }
            //var sTUDENTs = db.STUDENTs.Include(s => s.COUNTRY);
            //return View(sTUDENTs.ToList());
            return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
        }

        // GET: STUDENTs/Details/5
        public ActionResult Details(string userGUID, int? id)
        {

            UserVM UserViewModel = new UserVM();

            if (UserViewModel.UserLoggedIn(db, userGUID) && UserViewModel.User.StudentID == 1 || UserViewModel.User.StudentID == 2)
            {
                UserViewModel.RefreshGUID(db);

                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                STUDENT sTUDENT = db.STUDENTs.Find(id);
                StudentVM StudentVM = new StudentVM();
                StudentVM.UserViewModel = UserViewModel;
                StudentVM.students.Add(sTUDENT);
                if (sTUDENT == null)
                {
                    return HttpNotFound();
                }
                return View(sTUDENT);
            }
            return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
        }
        // GET: STUDENTs/Create
        public ActionResult Create()
        {
            ViewBag.CountryID = new SelectList(db.COUNTRies, "CountryID", "CountryName");
            return View();
        }

        // POST: STUDENTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Name,Surname,PhoneNumber,CountryID")] STUDENT sTUDENT)
        {
            if (ModelState.IsValid)
            {
                db.STUDENTs.Add(sTUDENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryID = new SelectList(db.COUNTRies, "CountryID", "CountryName", sTUDENT.CountryID);
            return View(sTUDENT);
        }

        // GET: STUDENTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STUDENT sTUDENT = db.STUDENTs.Find(id);
            if (sTUDENT == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryID = new SelectList(db.COUNTRies, "CountryID", "CountryName", sTUDENT.CountryID);
            return View(sTUDENT);
        }

        // POST: STUDENTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Name,Surname,PhoneNumber,CountryID")] STUDENT sTUDENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTUDENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryID = new SelectList(db.COUNTRies, "CountryID", "CountryName", sTUDENT.CountryID);
            return View(sTUDENT);
        }

        // GET: STUDENTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STUDENT sTUDENT = db.STUDENTs.Find(id);
            if (sTUDENT == null)
            {
                return HttpNotFound();
            }
            return View(sTUDENT);
        }

        // POST: STUDENTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STUDENT sTUDENT = db.STUDENTs.Find(id);
            db.STUDENTs.Remove(sTUDENT);
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
