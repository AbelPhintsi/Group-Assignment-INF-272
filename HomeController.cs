using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandomApp.Models;
using System.Text;
using System.Security.Cryptography;
using RandomApp.viewModels;

namespace RandomApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }


        DatabaseRandomEntities db = new DatabaseRandomEntities();
        [HttpPost]

        public ActionResult Login(string Username, string Password)
        {
            var HashedPassword = ComputeSha256Hash(Password);
            Models.USER user = db.USERs.Where(zz => zz.UserEmail == Username && zz.UserPassword == HashedPassword).FirstOrDefault();

            if (user != null)
            {
                UserVM UserViewModel = new UserVM();
                UserViewModel.User = user;
                UserViewModel.RefreshGUID(db);
                TempData["UserViewModel"] = UserViewModel;
                return RedirectToAction("Index", "Students");

            }

            return RedirectToAction("Index", "Home", "Ërror");
        }

        string ComputeSha256Hash(string rawData)
        {
            using (SHA256 Sha256Hash = SHA256.Create())
            {
                byte[] bytes = Sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //[HttpPost]
        //public ActionResult Index(USER obj)

        //{
           // if (ModelState.IsValid)
           // {
               // DatabaseRandomEntities db = new DatabaseRandomEntities();
                //db.USERs.Add(obj);
                //db.SaveChanges();
            //}
           // return View(obj);
        //}

       // [HttpPost]
       // public ActionResult SignUp(UserVM user)
       // {
          //  System.Diagnostics.Debugger.Break();
            //Write the code to add user to the database
           // return View();
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}