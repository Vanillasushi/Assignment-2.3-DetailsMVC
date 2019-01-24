using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Video.Shared.Orchestrators.Interfaces;
using Week4Video.Shared.ViewModels;

namespace Week4Video.Shared.Orchestrators
{
    public class CourseOrchestrator : ICourseOrchestrator
    {
        public List<CourseViewModel> GetAllCourses()
        {
            var courses = new List<CourseViewModel>
            {
                new CourseViewModel
                {
                    Capacity = 25,
                    CourseName = "Intro to C#",
                    CourseNumber = 169,
                    Department = "CIS"
                },
                new CourseViewModel
                {
                    Capacity = 20,
                    CourseName = "Advanced C#",
                    CourseNumber = 174,
                    Department = "CIS"
                }
            };

            return courses;
        }
    }
}
