using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Student_Management_System.general
{
    public class ApplicationSettings
    {
        public static string ConnectionString() {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}
