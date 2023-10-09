using BusinessLayer.BaseRepository;
using Modellayer.Models;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.StudentAcademicLogics
{
    public class StudentAcademyBL : IStudentAcademyBL
    {
        //private readonly AppDbContext context;
        private readonly IBaseRepository _baseRepository;

        public StudentAcademyBL(IBaseRepository baseRepository)
        {
            this._baseRepository = baseRepository;
        }
        public async Task<StudentAcademic> Add(StudentAcademic studentAcademic)
        {
            return await _baseRepository.Create<StudentAcademic>(studentAcademic);
            /*
                        context.StudentAcademic.Add(studentAcademic);
                        context.SaveChanges();*/
            return studentAcademic;

        }

        public async Task<StudentAcademic> Delete(int id)
        {

            return await _baseRepository.Delete<StudentAcademic>(id);
            
/*
            StudentAcademic studentAcademic = context.StudentAcademic.Find(id);
            if (studentAcademic != null)
            {
                context.StudentAcademic.Remove(studentAcademic);
                context.SaveChanges();

            }
            return studentAcademic;*/
        }

        public async Task<IEnumerable<StudentAcademic>> GetAllStudentAcademic()
        {

            return _baseRepository.GetAllList<StudentAcademic>();
            /*return context.StudentAcademic;*/
        }

        public async Task<StudentAcademic> GetStudentAcademic(int Id)
        {
            return await _baseRepository.GetDataById<StudentAcademic>(Id);
        }

        public async Task<StudentAcademic> Update(StudentAcademic studentAcademicUpdate)
        {

            return await _baseRepository.Update<StudentAcademic>(studentAcademicUpdate);
        }
    }
}
