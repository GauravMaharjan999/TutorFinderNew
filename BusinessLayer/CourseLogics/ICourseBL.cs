using Modellayer.Models;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.StudentLogics
{
    public interface ICourseBL
    {
        Task<List<TrainingCourse>> GetAllCourses();
        Task<TrainingCourse> GetCourseById(int id);

	}
}
