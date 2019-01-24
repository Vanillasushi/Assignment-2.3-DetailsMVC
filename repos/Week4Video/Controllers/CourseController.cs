using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week4Video.Models;
using Week4Video.Shared.Enums;
using Week4Video.Shared.Orchestrators;
using Week4Video.Shared.ViewModels;

namespace Week4Video.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var courseOrchestrator = new CourseOrchestrator();

            var semesterModel = new SemesterModel
            {
                Courses = courseOrchestrator.GetAllCourses(),
                Semester = SemesterEnum.Fall,
                Year = 2018
            };

            var detailsModel = new DetailsModel
            {
                FirstName = "Henry",
                LastName = "Dang",
                Gender = GenderEnum.Male,
                Age = 21,
                Major = "BIS"
            };

            return View(detailsModel);
        }
    }
}