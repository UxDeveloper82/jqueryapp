using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jquery.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Position { get; set; }

        public string Office { get; set; }

        public int Salary { get; set; }

        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFile ImageUpload { get; set; }

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/user.png";
        }
    }
}