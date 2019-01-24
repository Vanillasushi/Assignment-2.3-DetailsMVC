using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week4Video.Shared.Enums;
using Week4Video.Shared.ViewModels;
using Week4Video.Shared.Orchestrators;
using System.ComponentModel;

namespace Week4Video.Models
{
    public class SemesterModel
    {
        public int Year { get; set; }
        public SemesterEnum Semester { get; set; }
        public string SemesterName => Semester.ToString();
        [DisplayName("Semester Name: ")]
        public List<CourseViewModel> Courses { get; set; }
    }
}