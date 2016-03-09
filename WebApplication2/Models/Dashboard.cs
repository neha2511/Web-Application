using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Dashboard
    {
        public string Course { get; set; }
        public string  Concentration { get; set; }
        public string  Semester { get; set; }
        [Display(Name = "No of Semesters")]
        public string NumberofSemesters { get; set; }
        public string  Elective { get; set; }
    }
}