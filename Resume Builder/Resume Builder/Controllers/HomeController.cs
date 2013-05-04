using System;
using System.Web.Mvc;
using ResumeBuilder.Core.Entity;

namespace ResumeBuilder.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult cv()
        {
            //ResumeBuilder.Core
            Resume r = new Resume();
            return View(r);
        }

        [HttpPost]
        public ActionResult cv(Resume r)
        {
            r.Email = "dsfsdf";
            r.LastUpdated = DateTime.UtcNow;
            r.PhoneNumber = "3";
            using (ResumeBuilder.Core.ResumeModelContainer db = new Core.ResumeModelContainer())
            {
                int X = 0;
            }
            //using(User

            //using (ResumeModelContainer db = new ResumeModelContainer())
            //{
            //    User u = new User();
            //    u.UserIDKey = 54;
            //    u.TestValue = "plzwork";
            //    db.AddToUsers(u);

            //    r.UserUserIDKey = u.UserIDKey;

            //    db.AddToResumes(r);
            //    db.SaveChanges();
            //}

            return View(r);
        }

        public ActionResult About()
        {
            return View();
        }


    }
}
