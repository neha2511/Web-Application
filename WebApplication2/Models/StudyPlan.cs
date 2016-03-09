using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class StudyPlan
    {
        public String Semester { get; set; }
        [Display (Name="Course Name")]
        public String CourseName { get; set; }
        public int Credits { get; set; }
        [Display(Name = "Course Number")]
        public int CourseNumber { get; set; }
        
        }
    }