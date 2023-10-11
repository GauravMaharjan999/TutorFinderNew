
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Modellayer.Models;
using Modellayer.Models.PredicateBuilder;
using BusinessLayer.BaseRepository;
using BusinessLayer.HelperTools;
using Modellayer.Models.Enums;

using Newtonsoft.Json;

namespace BusinessLayer.StudentLogics
{
    public class StudentRecordBL : IStudentRecordBL

    {

        private readonly AppDbContext context;
        private readonly IBaseRepository _baseRepository;
        private readonly IHelperTool _helperTool;
        private readonly IHostingEnvironment _hostingEnvironment;


        public StudentRecordBL(AppDbContext context, IBaseRepository baseRepository, IHelperTool helperTool
                                , IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            _baseRepository = baseRepository;
            _helperTool = helperTool;
            _hostingEnvironment = hostingEnvironment;
        }
        Expression<Func<StudentRecord, bool>> PredicateFilter(string queryName,
             string queryMobileNumber, string queryAddress, int queryRollNo, string queryClass,
             string queryBloodGroup, string queryGender, string queryBirthDate, string pq_filter = null)
        {
            var searchCondition = PredicateBuilder.True<StudentRecord>();
            if (pq_filter != null)
            {
                var filterResult = JsonConvert.DeserializeObject<PQ>(pq_filter);
                var finalFilterResult = filterResult.data;
                foreach (var item in finalFilterResult)
                {

                    var itemIndex = item.dataIndx.ToString();
                    switch (itemIndex)
                    {

                        case "concatName":

                            {
                                if (!String.IsNullOrEmpty(item.value))
                                {
                                    searchCondition = searchCondition.And(p => String.Concat(p.FirstName, p.MiddleName, p.LastName).ToLower().Contains(item.value.ToLower().Trim()));
                                };
                            }

                            break;


                        case "mobileNumber":
                            {
                                if (!String.IsNullOrEmpty(item.value))
                                {
                                    searchCondition = searchCondition.And(p => p.MobileNumber.Contains(item.value.Trim()));
                                }
                            }

                            break;


                        case "rollNo":
                            {
                                var rollNoToInt = Int32.Parse(item.value);
                                if (rollNoToInt > 0)

                                {

                                    searchCondition = searchCondition.And(p => p.RollNo.Equals(rollNoToInt));
                                }
                            }

                            break;



                        case "address":
                            {
                                if (!String.IsNullOrEmpty(item.value))
                                {
                                    searchCondition = searchCondition.And(p => p.Address.ToLower().Contains(item.value.ToLower().Trim()));
                                }
                            }
                            break;


                        case "bloodGroup":
                            {
                                /*  if (!String.IsNullOrEmpty(item.value))
                                  {
                                      searchCondition = searchCondition.And(p => p.BloodGroup.Equals(item.value.Trim()));
                                  }
  */
                                int iBloodGroupValue;
                                bool isSuccess = int.TryParse(item.value, out iBloodGroupValue);


                                if (isSuccess == true && iBloodGroupValue > 0 && iBloodGroupValue <= 3)
                                {
                                    BloodGroupEnum enumValueOfGender = (BloodGroupEnum)iBloodGroupValue;

                                    searchCondition = searchCondition.And(p => p.BloodGroup.Equals(enumValueOfGender));


                                }

                            }
                            break;

                        case "class":
                            {
                                var classNoToInt = Int32.Parse(item.value);
                                if (classNoToInt >= 1 && classNoToInt <= 10)

                                {

                                    searchCondition = searchCondition.And(p => p.Class.Equals(classNoToInt));
                                }
                            }
                            break;


                        case "birthDate":
                            {

                                /*string[] charsToTrim = { "T00:00:00" };*/
                                if (!String.IsNullOrEmpty(item.value))

                                {
                                    searchCondition = searchCondition.And(p => p.BirthDate.ToString("MM/dd/yyyy").Contains(item.value));
                                }
                            }
                            break;


                        case "gender":

                            int iValue;
                            bool success = int.TryParse(item.value, out iValue);
                            var genderValue = Int32.Parse(item.value);

                            if (success == true && iValue > 0 && iValue <= 3)
                            {
                                GenderEnum enumValue = (GenderEnum)iValue;

                                searchCondition = searchCondition.And(p => p.Gender.Equals(enumValue));


                            }


                            break;


                    }
                    /* if (item.dataIndx == "firstName")
                     {
                         if (!String.IsNullOrEmpty(item.value))
                         {
                             searchCondition = searchCondition.And(p => String.Concat(p.FirstName, p.MiddleName, p.LastName).ToLower().Contains(item.value.ToLower().Trim()));
                         }
                         //searchCondition = searchCondition.And(p => String.Concat(p.FirstName, p.MiddleName, p.LastName).ToLower().Contains(queryName.ToLower().Trim()));

                     }
                     if (item.dataIndx == "mobileNumber")
                     {

                     }*/



                }
            }


            /*
                        if (!String.IsNullOrEmpty(queryClass))
                        {
                            searchCondition = searchCondition.And(p => p.Class.Equals(queryClass.Trim()));
                        }

                        if (!String.IsNullOrEmpty(queryName))
                        {

                            searchCondition = searchCondition.And(p => String.Concat(p.FirstName, p.MiddleName, p.LastName).ToLower().Contains(queryName.ToLower().Trim()));
                        }
                        if (!String.IsNullOrEmpty(queryMobileNumber))
                        {
                            searchCondition = searchCondition.And(p => p.MobileNumber.Contains(queryMobileNumber.Trim()));
                        }
                        if (!String.IsNullOrEmpty(queryAddress))
                        {
                            searchCondition = searchCondition.And(p => p.Address.ToLower().Contains(queryAddress.ToLower().Trim()));
                        }

                        if (queryRollNo > 0)
                        {
                            searchCondition = searchCondition.And(p => p.RollNo.Equals(queryRollNo));
                        }

                        if (!String.IsNullOrEmpty(queryClass))
                        {
                            searchCondition = searchCondition.And(p => p.Class.Equals(queryClass.Trim()));
                        }


                        if (!String.IsNullOrEmpty(queryBloodGroup))
                        {
                            searchCondition = searchCondition.And(p => p.BloodGroup.Equals(queryBloodGroup.Trim()));
                        }
                        if (!String.IsNullOrEmpty(queryGender))
                        {
                            searchCondition = searchCondition.And(p => p.Gender.Equals(queryGender.Trim()));
                        }
                        if (!String.IsNullOrEmpty(queryBirthDate))
                        {
                            searchCondition = searchCondition.And(p => p.BirthDate.ToString().Contains(queryMobileNumber.Trim()));
                        }*/

            searchCondition = searchCondition.And(p => 0 == 0);
            return searchCondition;
        }

        public async Task<IEnumerable<StudentRecord>> GetStudents()
        {
            var list = _baseRepository.GetAllList<StudentRecord>();

            return list;
        }



        public async Task<DataResult> Add(StudentViewModel studentViewModel)
        {
            var checkDuplicate = _baseRepository.GetAllList<StudentRecord>().Where(x => x.RollNo == studentViewModel.RollNo && x.Id != studentViewModel.Id).FirstOrDefault();

            if (checkDuplicate != null)
            {
                //ModelState.AddModelError("RollNo", "RollNo is already taken");
                //return View();
                return new DataResult { ResultType = ResultTypeEnum.Failed, Message = "RollNo. Is Already Taken.." };
            }


            string uniqueFileName = null;

            if (studentViewModel.PhotoInput != null)
            {

                // The image must be uploaded to the images folder in wwwroot
                // To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                uniqueFileName = Guid.NewGuid().ToString() + "_" + studentViewModel.PhotoInput.FileName;


                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                studentViewModel.PhotoInput.CopyTo(new FileStream(filePath, FileMode.Create));

                /*
                 Global unique identify 
                Every time we call the guid it returns new unique identifier
                */
            }


            StudentRecord newStudentRecord = new StudentRecord
            {
                Id = studentViewModel.Id,
                FirstName = studentViewModel.FirstName,

                MiddleName = studentViewModel.MiddleName,

                LastName = studentViewModel.LastName,
                RollNo = studentViewModel.RollNo,
                Address = studentViewModel.Address,
                Class = studentViewModel.Class,
                BloodGroup = studentViewModel.BloodGroup,
                MobileNumber = studentViewModel.MobileNumber,
                BirthDate = studentViewModel.BirthDate,
                Gender = studentViewModel.Gender,
                Photo = uniqueFileName,
                StudentAcademic = studentViewModel.StudentAcademicList.Select(x => new StudentAcademic
                {
                    BoardId = x.BoardId,
                    StudentAcademicId = x.Id,
                    College = x.College,
                    Percentage = x.Percentage,
                    Division = x.Division,
                }).ToList(),
            };




            var result = await _baseRepository.Add<StudentRecord>(newStudentRecord);

            return result;
            //context.StudentRecord.Add(student);
            //context.SaveChanges();
            //return student;


        }

        public async Task<StudentRecord> Delete(int Id)
        {
            return await _baseRepository.Delete<StudentRecord>(Id);
        }

        public IQueryable<StudentRecord> GetAllStudents() //current page and row per pages
        {

            //var totalRecords = await _baseRepository.GetListCount<StudentRecord>();
            var List = _baseRepository.GetAllList<StudentRecord>();

            /*            var finalList = new StudentViewModel
                        {
                            Id = List.Id,
                            FirstName = List.FirstName,

                            MiddleName = List.MiddleName,

                            LastName = List.LastName,
                            RollNo = List.RollNo,
                            Address = List.Address,
                            Class = List.Class,
                            BloodGroup = List.BloodGroup,
                            MobileNumber = List.MobileNumber,
                            BirthDate = List.BirthDate,
                            Gender = List.Gender,
                            Photo = uniqueFileName,
                            StudentAcademic = List.StudentAcademicList
                        }
            */
            return List;

            //return  context.StudentRecord;
        }

        public async Task<GridIndexData> GetAllStudentsIndexData(PredicateFilter pq)
        {
            try
            {

                GridIndexData gid = new GridIndexData();
                //var totalRecords = await _baseRepository.GetListCount<StudentRecord>();
                var totalRecords = _baseRepository.GetAllList<StudentRecord>().Where(PredicateFilter(pq.queryName,
                pq.queryMobileNumber, pq.queryAddress, pq.queryRollNo, pq.queryClass,
                pq.queryBloodGroup, pq.queryGender, pq.queryBirthDate, pq.pq_filter)).Count();

                int skip = await _helperTool.GetPageSkip(pq.pq_curpage, pq.pq_rPP, totalRecords);

                var data = _baseRepository.GetAllList<StudentRecord>().Where(PredicateFilter(pq.queryName,
                                                                           pq.queryMobileNumber, pq.queryAddress, pq.queryRollNo, pq.queryClass,
                                                                           pq.queryBloodGroup, pq.queryGender, pq.queryBirthDate, pq.pq_filter))
                                                                       .OrderBy(x => x.RollNo).Skip(skip).Take(pq.pq_rPP);
                var finalData = data.Select(x => new StudentViewModel
                {
                    Id = x.Id,
                    Gender = x.Gender,
                    FirstName = x.FirstName,
                    Address = x.Address,
                    BirthDate = x.BirthDate,
                    BloodGroup = x.BloodGroup,
                    LastName = x.LastName,
                    MiddleName = x.MiddleName,
                    Photo = x.Photo,
                    RollNo = x.RollNo,
                    Class = x.Class,
                    MobileNumber = x.MobileNumber,

                    PhotoPath = x.Photo != null ? $"<img src ='/images/{x.Photo}' width='50%' height='50%' style='border-radius:50%'/> " : $"<img src ='/images/employee_pic.jpg' width='50%' height='50%' style='border-radius:50%'/> ",

                    ConcatName = $"{x.FirstName} {x.MiddleName} {x.LastName}"



                });
                ;
                gid.totalRecords = totalRecords;
                gid.curPage = pq.pq_curpage;
                gid.dataRow = finalData;
                return gid;

            }
            catch (Exception ex)
            {

                throw;
            }

            //return  context.StudentRecord;
        }

        public async Task<StudentRecord> GetStudent(int Id)
        {
            //return await _baseRepository.GetDataById<StudentRecord>(Id);
            var student = _baseRepository.GetAllList<StudentRecord>().Include(x => x.StudentAcademic).Where(x => x.Id.Equals(Id)).AsNoTracking().FirstOrDefault(); // returns StudendRecord including StudentAcademic 
            return student;
            //return context.StudentRecord.Find(Id);
        }
        public async Task<StudentViewModel> GetStudentRecordDetailById(int Id)
        {
            //return await _baseRepository.GetDataById<StudentRecord>(Id);
            var studentRecord = _baseRepository.GetAllList<StudentRecord>().Include(x => x.StudentAcademic).Where(x => x.Id.Equals(Id)).AsNoTracking().FirstOrDefault(); // returns StudendRecord including StudentAcademic 

            //creating photo path including full root
            var photoPath = "/images/" + (studentRecord.Photo ?? "employee_pic.jpg");



            //Assiging previous value of student record to new object of studentViewModel
            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Id = studentRecord.Id,
                FirstName = studentRecord.FirstName,

                MiddleName = studentRecord.MiddleName,

                LastName = studentRecord.LastName,
                RollNo = studentRecord.RollNo,
                Address = studentRecord.Address,
                Class = studentRecord.Class,
                BloodGroup = studentRecord.BloodGroup,
                MobileNumber = studentRecord.MobileNumber,
                BirthDate = studentRecord.BirthDate,
                Gender = studentRecord.Gender,
                Photo = studentRecord.Photo, //Get the saved photo name
                PhotoPath = photoPath,
                StudentAcademicList = studentRecord.StudentAcademic.Select(x => new StudentAcademicViewModel
                {
                    Id = x.StudentAcademicId,
                    BoardId = x.BoardId,
                    College = x.College,
                    Division = x.Division,
                    Percentage = x.Percentage,
                    StudentId = x.StudentId,
                    BoardName = x.BoardId.ToString()
                }).ToList(),

            };
            return studentViewModel;
            //return context.StudentRecord.Find(Id);
        }

        public async Task<DataResult> Update(StudentViewModel model)
        {
            try
            {

             /*   if (model.RollNo <= 0)
                {
                 
                    return new DataResult { ResultType = Enums.ResultTypeEnum.Failed, Message = "RollNo. Is Already Taken.." };

                }*/

                string uniqueFileName = null;
                //if user attach new image then go 
                if (model.PhotoInput != null)
                {

                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name( Global Unique Identifier)
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoInput.FileName;


                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.PhotoInput.CopyTo(new FileStream(filePath, FileMode.Create));

                    /*
                     Global unique identify 
                    Every time we call the guid it returns new unique identifier
                    */
                }

                else
                {
                    uniqueFileName = "employee_pic.jpg";
                }
               

                StudentRecord updatedModel = await _baseRepository.GetAllList<StudentRecord>().Where(x => x.Id == model.Id).Include(x => x.StudentAcademic).AsNoTracking().FirstOrDefaultAsync();

                /*    var updateModel = await GetStudentRecordDetailById(model.Id)*/


                updatedModel.FirstName = model.FirstName;
                updatedModel.MiddleName = model.MiddleName;
                updatedModel.LastName = model.LastName;
                updatedModel.RollNo = model.RollNo;
                updatedModel.Address = model.Address;
                updatedModel.Class = model.Class;
                updatedModel.BloodGroup = model.BloodGroup;
                updatedModel.MobileNumber = model.MobileNumber;
                updatedModel.BirthDate = model.BirthDate;
                updatedModel.Gender = model.Gender;
                updatedModel.StudentAcademic = model.StudentAcademicList.Select(x => new StudentAcademic
                {
                    StudentAcademicId = 0,
                    StudentId = x.StudentId,
                    BoardId = x.BoardId,
                    Division = x.Division,
                    Percentage = x.Percentage,
                    College = x.College,
                }).ToList();

                if (model.PhotoInput!=null)
                {
                    updatedModel.Photo = uniqueFileName;
                }


                var studentAcademicViewModelDelList = new List<StudentAcademicViewModel>();

                var temp = await GetStudentRecordDetailById(model.Id);
                studentAcademicViewModelDelList = temp.StudentAcademicList;
                /*studentAcademicDelList = model.StudentAcademicList.Where(x=>x.Id > 0).Select(x=> new StudentAcademic {
                    StudentAcademicId=x.Id
                }).ToList();*/



                var studentAcademicDelList = studentAcademicViewModelDelList.Select(x => new StudentAcademic
                {
                    StudentAcademicId = x.Id,
                    StudentId = x.StudentId

                });
                var result = await _baseRepository.UpdateModelDetails<StudentRecord, StudentAcademic>(updatedModel, studentAcademicDelList.ToArray());

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public IQueryable<StudentRecord> GetStudentRecordByStoredProcedure(int cur_p, int rpp)
        {

            try
            {
                var result = context.StudentRecord.FromSql<StudentRecord>($"getpagination {cur_p}, {rpp}");
                return result;
            }
            catch (Exception)
            {
                    
                throw;
            }
        }
    }
}
