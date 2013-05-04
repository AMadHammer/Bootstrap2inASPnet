using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeBuilder.Core.Entity
{
    public class Resume
    {
        public int ResumeIDKey;// int IDENTITY(1,1) NOT NULL,
        public DateTime LastUpdated;// datetime  NOT NULL,
        public string FirstName;// nvarchar(max)  NOT NULL,
        public string LastName;// nvarchar(max)  NOT NULL,
        public string MiddleName;// nvarchar(max)  NOT NULL,
        public string MissionStatement;// nvarchar(max)  NOT NULL,
        public string School;// nvarchar(max)  NOT NULL,
        public string Certifications;// nvarchar(max)  NOT NULL,
        public string JobExperience;// nvarchar(max)  NOT NULL,
        public string Email;// nvarchar(max)  NOT NULL,
        public string PhoneNumber;// nvarchar(max)  NOT NULL,
        public int UserUserIDKey;// int  NOT NULL

        public Resume()
        {
        }

        public Resume(string FirstName, string LastName, string MiddleName, string MissionStatement, string School, string Certifications, string JobExperience, string Email, string PhoneNumber, int UserUserIDKey)
        {
            //this.ResumeIDKey = ResumeIDKey;//
            //this.LastUpdated = LastUpdated;//
            this.FirstName = FirstName;//
            this.LastName = LastName;//
            this.MiddleName = MiddleName;//
            this.MissionStatement = MissionStatement;//
            this.School = School;//
            this.Certifications = Certifications;//
            this.JobExperience = JobExperience;//
            this.Email = Email;//
            this.PhoneNumber = PhoneNumber;//
            this.UserUserIDKey = UserUserIDKey;//
        }

        //    r.Email = "dsfsdf";
        //r.LastUpdated = DateTime.UtcNow;
        //r.PhoneNumber = "3";

        ////using(User

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

        //return View(r);
    }
}