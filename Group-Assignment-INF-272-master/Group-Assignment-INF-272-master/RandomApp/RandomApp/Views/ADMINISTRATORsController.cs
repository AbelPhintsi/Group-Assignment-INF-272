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
    public class ADMINISTRATORsController : Controller
    {
        private DatabaseRandomEntities db = new DatabaseRandomEntities();

        // GET: ADMINISTRATORs
        public ActionResult Index()
        {
            UserVM UserViewModel = TempData["UserViewModel"] as UserVM;

            if (UserViewModel.UserLoggedIn(db))
            {
                UserViewModel.RefreshGUID(db);
                AdminVM AdministratorVM = new AdminVM();
                AdministratorVM.UserViewModel = UserViewModel;
                AdministratorVM.administrators = db.ADMINISTRATORs.ToList();
                return View(AdministratorVM);
            }

            // return View(db.ADMINISTRATORs.ToList());
            return new HttpStatusCodeResult(HttpStatusCode.Forbidden);

        }

        // GET: ADMINISTRATORs/Details/5
        public ActionResult Details(string userGUID, int? id)
        {

            UserVM UserViewModel = new UserVM();
            if (UserViewModel.UserLoggedIn(db, userGUID) && UserViewModel.User.AdministratorID==1 || UserViewModel.User.AdministratorID == 2)
            {
                UserViewModel.RefreshGUID(db);
               

                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                ADMINISTRATOR aDMINISTRATOR = db.ADMINISTRATORs.Find(id);
                AdminVM AdministratorVM = new AdminVM();
                AdministratorVM.UserViewModel = UserViewModel;
                AdministratorVM.administrators.Add(aDMINISTRATOR);
                if (aDMINISTRATOR == null)
                {
                    return HttpNotFound();
                }
                return View(aDMINISTRATOR);
            }

            return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
        }

        // GET: ADMINISTRATORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMINISTRATORs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministratorID,Name,Surname,EmailAddress,DateEmployed,Active")] ADMINISTRATOR aDMINISTRATOR)
        {
            if (ModelState.IsValid)
            {
                db.ADMINISTRATORs.Add(aDMINISTRATOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aDMINISTRATOR);
        }

        // GET: ADMINISTRATORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRATOR aDMINISTRATOR = db.ADMINISTRATORs.Find(id);
            if (aDMINISTRATOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRATOR);
        }

        // POST: ADMINISTRATORs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministratorID,Name,Surname,EmailAddress,DateEmployed,Active")] ADMINISTRATOR aDMINISTRATOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aDMINISTRATOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aDMINISTRATOR);
        }

        // GET: ADMINISTRATORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRATOR aDMINISTRATOR = db.ADMINISTRATORs.Find(id);
            if (aDMINISTRATOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRATOR);
        }

        // POST: ADMINISTRATORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADMINISTRATOR aDMINISTRATOR = db.ADMINISTRATORs.Find(id);
            db.ADMINISTRATORs.Remove(aDMINISTRATOR);
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
