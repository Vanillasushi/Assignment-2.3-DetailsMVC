using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Video.Shared.ViewModels;

namespace Week4Video.Shared.Orchestrators.Interfaces
{
    public interface ICourseOrchestrator
    {
        List<CourseViewModel> GetAllCourses();
    }
}
