
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Modellayer.Models;
using BusinessLayer.StudentLogics;
using BusinessLayer.BaseRepository;
using Modellayer.Models.Enums;

namespace StudentManagement.ApiControllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : Controller
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IStudentRecordBL _studentRecordBL;
        public StudentApiController(IBaseRepository baseRepository, IStudentRecordBL studentRecordBL)
        {
            _baseRepository = baseRepository;
            _studentRecordBL = studentRecordBL;
        }

     

        [HttpGet("IndexData")]
        public async Task<GridIndexData> IndexData(int pq_curpage, int pq_rPP, string pq_filter)
        {
            GridIndexData gridIndexData = new GridIndexData();
            

            //JArray jArray= JArray.Parse(pq_filter);

            //var listData = jArray.Select(p => new PQ
            //{
            //    mode = (string)p["mode"],
            //    data = (List<Datas>)p["data"]
            //}).ToList();



            /*   
                  var model = (await _studentRecordBL.GetAllStudentsIndexData(pq_filter));
                  ViewBag.QueryName = pq_filter.queryName;
                  ViewBag.QueryMobileNumber = pq_filter.queryMobileNumber;
                  ViewBag.QueryRollNo = pq_filter.queryRollNo;
      */

            /* ViewBag.LoginStatus = true;
             return model;*/
            return gridIndexData;
        }

        [HttpGet("GetAllStudents")]
        public async Task<IEnumerable<StudentViewModel>> GetAllStudents()
        {


            var data = await (from sr in _baseRepository.GetAllList<StudentRecord>().Include(x => x.StudentAcademic).AsNoTracking()
                              select new StudentViewModel
                              {
                                  Id = sr.Id,
                                  FirstName = sr.FirstName,

                                  MiddleName = sr.MiddleName,

                                  LastName = sr.LastName,
                                  RollNo = sr.RollNo,
                                  Address = sr.Address,
                                  Class = sr.Class,
                                  BloodGroup = sr.BloodGroup,
                                  MobileNumber = sr.MobileNumber,
                                  BirthDate = sr.BirthDate.Date,
                                  Gender = sr.Gender,
                                  Photo = sr.Photo, //Get the saved photo name
                                  /*PhotoPath = $"< img src = "/images/" + "({sr.Photo} ?? "employee_pic.jpg")" /"" /> ",*/
                                  StudentAcademicList = sr.StudentAcademic.Select(y => new StudentAcademicViewModel
                                  {
                                      Id = y.StudentAcademicId,
                                      StudentId = sr.Id,
                                      BoardId = y.BoardId,
                                      College = y.College,
                                      Division = y.Division

                                  }
                            ).ToList()
                              }).ToListAsync();


            return data;
        }

        [HttpGet("GetStudentDataById/{StudentId}")]
        public async Task<StudentViewModel> GetStudentDataById([FromRoute] int StudentId/*,[FromQuery] int AcademicId*/)

        {
            StudentRecord studentRecord = await _studentRecordBL.GetStudent(StudentId);
            var data1 = await _baseRepository.GetDataById<StudentRecord>(StudentId);


            var data = (from sr in _baseRepository.GetAllList<StudentRecord>().Include(x => x.StudentAcademic).AsNoTracking()
                        select new StudentViewModel
                        {
                            Id = sr.Id,
                            FirstName = sr.FirstName,

                            MiddleName = sr.MiddleName,

                            LastName = sr.LastName,
                            RollNo = sr.RollNo,
                            Address = sr.Address,
                            Class = sr.Class,
                            BloodGroup = sr.BloodGroup,
                            MobileNumber = sr.MobileNumber,
                            BirthDate = sr.BirthDate,
                            Gender = sr.Gender,
                            Photo = sr.Photo, //Get the saved photo name
                            StudentAcademicList = sr.StudentAcademic.Select(y => new StudentAcademicViewModel
                            {
                                Id = y.StudentAcademicId,
                                StudentId = sr.Id,
                                BoardId = y.BoardId,
                                College = y.College,
                                Division = y.Division

                            }
                      ).ToList()
                        }).Where(x => x.Id == StudentId).FirstOrDefault();



            return data;
        }

        [HttpPost("CreateStudent")]
        public async Task<DataResult> Post([FromBody] StudentViewModel model)
        {


            var result = await _studentRecordBL.Add(model);

            return new DataResult { ResultType = result.ResultType, Message = result.Message };

        }

        [HttpPut("UpdateStudent/{id}")]
        public async Task<DataResult> Put(int id, [FromBody] StudentViewModel model)
        {

            model.Id = id;
            StudentViewModel studentRecord = await _studentRecordBL.GetStudentRecordDetailById(id);

            model.RollNo = studentRecord.RollNo;


/*
            for (int i = 0; i < studentRecord.StudentAcademic.Count(); i++)
            {
                model.StudentAcademicList[i].StudentAcademicId = studentRecord.StudentAcademic[i].StudentAcademicId;
            }*/
            var result = await _studentRecordBL.Update(model);

            return new DataResult { ResultType = result.ResultType, Message = result.Message };

        }

        [HttpDelete("DeleteStudent/{Id}")]

        public async Task<DataResult> Delete(int Id)
        {
            var result = await _studentRecordBL.Delete(Id);


            if (result == null)
            {
                return new DataResult { ResultType = ResultTypeEnum.Failed, Message = "Id not found" };
            }


            return new DataResult { ResultType = ResultTypeEnum.Success, Message = "Sucessfully deleted" };

        }




    }
}
