using Modellayer.Models;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.StudentLogics
{
    public interface IStudentRecordBL
    {
        Task<DataResult> Add(StudentViewModel studentViewModel);
        Task<StudentRecord> Delete(int id);

        Task<DataResult> Update(StudentViewModel model);
        Task<StudentRecord> GetStudent(int Id);


        /*  Task<IEnumerable<StudentRecord>> GetAllStudents(int pq_curpage, int pq_rPP,
              string queryName, string queryMobileNumber, string queryAddress, int queryRollNo,
              string queryClass,
             string queryBloodGroup, string queryGender, string queryBirthDate);
          *//*    Task<GridIndexData> GetAllStudentsIndexData(int pq_curpage, int pq_rPP,
                 string queryName, string queryMobileNumber, string queryAddress, int queryRollNo,
                 string queryClass,
                string queryBloodGroup, string queryGender, string queryBirthDate);*/


        IQueryable<StudentRecord> GetAllStudents();
        Task<GridIndexData> GetAllStudentsIndexData(PredicateFilter pq );
        Task<StudentViewModel> GetStudentRecordDetailById(int Id);

        //Task<IEnumerable<StudentAcademic>> GetAllStudentsAcademic(int studentId);

        IQueryable<StudentRecord> GetStudentRecordByStoredProcedure(int cur_p, int rpp);
    }
}
