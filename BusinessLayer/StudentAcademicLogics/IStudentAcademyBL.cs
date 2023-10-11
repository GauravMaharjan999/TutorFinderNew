using Modellayer.Models;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.StudentAcademicLogics
{
    interface IStudentAcademyBL
    {

        Task<StudentAcademic> Add(StudentAcademic studentAcademic);
        Task<StudentAcademic> Delete(int id);
        Task<IEnumerable<StudentAcademic>> GetAllStudentAcademic();

        Task<StudentAcademic> Update(StudentAcademic studentAcademicUpdate);
        Task<StudentAcademic> GetStudentAcademic(int Id);
    }
}
