using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeBuilder.Core.Entity
{
    public class User
    {
        public int UserIDKey; //int IDENTITY(1,1) NOT NULL,
        public string TestValue; // nvarchar(max)  NOT NULL
    }
}
