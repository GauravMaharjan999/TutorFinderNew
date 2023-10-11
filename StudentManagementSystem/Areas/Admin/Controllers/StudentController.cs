
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using StudentManagementSystem.ApplicationController;
using Microsoft.AspNetCore.Http;
using BusinessLayer.StudentLogics;
using Modellayer.Models;
using BusinessLayer.BaseRepository;
using Modellayer.Models.Enums;
using ClientNotifications;
using static ClientNotifications.Helpers.NotificationHelper;

namespace StudentManagement.Areas.Admin.Controllers
{
   /* [Authorize]*/
    [Area("Admin")]
    public class StudentController : BaseController

    {

        private IStudentRecordBL _studentRecordBL;
        private IEmployeeRepositary _employeeRepositary;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IBaseRepository _baseRepository;
        private readonly IClientNotification _clientNotification;
        public string GlobalPhoto { get; set; }


        public StudentController(IStudentRecordBL studentRecordBL, 
                                   IEmployeeRepositary employeeRepositary,
                                   IHostingEnvironment hostingEnvironment,
                                   IBaseRepository baseRepository,
                                   IClientNotification clientNotification
            )
        {
            _studentRecordBL = studentRecordBL;
            _employeeRepositary = employeeRepositary;
            _hostingEnvironment = hostingEnvironment;
            _baseRepository = baseRepository;
            _clientNotification = clientNotification;
        }


        [AcceptVerbs("Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsRollInUse(int id)
        {
            var RollNO = await _studentRecordBL.GetStudentRecordDetailById(id);

            if (RollNO == null)
            {
                return Json(true);
            }
            else
            {
                //return Json($"Roll No {RollNO} is already in use.");
                return Json(false);
            }

        }



        //[Route("admin/student/index")]
        public async Task<IActionResult> Index(PredicateFilter pq)
        {
            var model = _studentRecordBL.GetAllStudents();



            return PartialView(model);

        }


        public async Task<GridIndexData> IndexData(PredicateFilter pq)
        {
            GridIndexData gridIndexData = new GridIndexData();
            var model = (await _studentRecordBL.GetAllStudentsIndexData(pq));
            ViewBag.QueryName = pq.queryName;
            ViewBag.QueryMobileNumber = pq.queryMobileNumber;
            ViewBag.QueryRollNo = pq.queryRollNo;


            ViewBag.LoginStatus = true;
            return model;
           
        }
  

        public async Task<GridIndexData> GridIndexData(int pq_curpage, int pq_rPP, string pq_filter)
      {
            GridIndexData gridIndexData = new GridIndexData();
            PredicateFilter pq = new PredicateFilter();
            pq.pq_curpage = pq_curpage;
            pq.pq_rPP = pq_rPP;
            pq.pq_filter = pq_filter;

            var model = (await _studentRecordBL.GetAllStudentsIndexData(pq));

          /*  List<StudentViewModel> list = model.dataRow.Select(new StudentViewModel
            {

                FirstName = x.FirstName,


            });*/
            ViewBag.QueryName = pq.queryName;
            ViewBag.QueryMobileNumber = pq.queryMobileNumber;
            ViewBag.QueryRollNo = pq.queryRollNo;


            ViewBag.LoginStatus = true;
            return model;

        }





        [HttpPost]
        public IActionResult GetPhoto(StudentViewModel studentViewModel)
        {
            if (studentViewModel.PhotoInput != null)
            {

                // The image must be uploaded to the images folder in wwwroot
                // To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + studentViewModel.PhotoInput.FileName;


                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                studentViewModel.PhotoInput.CopyTo(new FileStream(filePath, FileMode.Create));


                GlobalPhoto = uniqueFileName;
            }

            return RedirectToAction("Create");
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            ViewBag.EmployeeList = _employeeRepositary.GetAllEmployees().ToList();
            StudentViewModel model = new StudentViewModel();

            return PartialView(model);
        }

        [HttpPost]
        [Authorize]
  /*      [ValidateAntiForgeryToken]*/
        public async Task<IActionResult> Create(StudentViewModel studentViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var isRollNoTaken = _studentRecordBL.GetAllStudents().Where(x => x.RollNo == studentViewModel.RollNo).ToList();
                    if (isRollNoTaken.Count > 0)
                    {
                        ModelState.AddModelError("RollNo", "RollNo is already taken");
                        return View(studentViewModel);
                    }
                    studentViewModel.Photo = GlobalPhoto;
     
                    ViewBag.EmployeeList = _employeeRepositary.GetAllEmployees().ToList();

                    var isDateValid = DateTime.Compare(DateTime.Now, studentViewModel.BirthDate); // return -1 if date is future

                    if (isDateValid == -1)
                    {
                        ModelState.AddModelError("BirthDate", "Date not allowed");
                        return View(studentViewModel);
                    }

                    var result = await _studentRecordBL.Add(studentViewModel);

                    _clientNotification.AddToastNotification("Created Successfully",
                                         NotificationType.success,
                                         new ToastNotificationOption
                                         {
                                             ProgressBar = true,
                                             PositionClass = "toast-bottom-right",
                                             CloseButton = true
                                         });


                    return RedirectToAction("Index");

                }

                _clientNotification.AddToastNotification("Error Occured",
                                               NotificationType.error,
                                               new ToastNotificationOption
                                               {
                                                   ProgressBar = true,
                                                   PositionClass = "toast-bottom-right",
                                                   CloseButton = true
                                               });
                ViewBag.EmployeeList = _employeeRepositary.GetAllEmployees().ToList();
                return PartialView(studentViewModel);

            }
            catch (Exception ex)
            {

                throw;
            }

        }



        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Edit(int id)
        
        {
            var studentViewModel = await _studentRecordBL.GetStudentRecordDetailById(id);

            return PartialView(studentViewModel);
        }





        [HttpPost]
        //[Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentViewModel model)
        {

            var prevStudrecords = await _studentRecordBL.GetStudent(model.Id);


            if (prevStudrecords.Photo == null)
            {
                model.PhotoPath = "/images/employee_pic.jpg";
            }
            else
            {
                model.PhotoPath = "/images/" + prevStudrecords.Photo;
            }
            if (ModelState.IsValid)
            {

               

                if (model.RollNo <= 0)
                {
                    ModelState.AddModelError("RollNo", "Rollno cant be less than 0");
                    return PartialView();

                }
                var isRollNoTaken = _studentRecordBL.GetAllStudents().Where(x => x.RollNo == model.RollNo && x.Id !=model.Id).ToList();

                if (isRollNoTaken.Count > 0)
                {
                    ModelState.AddModelError("RollNo", "RollNo is already taken");
                    return PartialView(model);
                }
                var result = await _studentRecordBL.Update(model);

              
                
                if (result.ResultType == ResultTypeEnum.Exception || result.ResultType == ResultTypeEnum.Failed) 
                {
                    return Json(result.Message);
                }

                _clientNotification.AddToastNotification("Edited Successfulyy",
                                          NotificationType.success,
                                          new ToastNotificationOption
                                          {
                                              ProgressBar = true,
                                              PositionClass = "toast-bottom-right",
                                              CloseButton = true
                                          });
                return RedirectToAction("Index");
            }


            _clientNotification.AddToastNotification("Error Occured",
                                       NotificationType.error,
                                       new ToastNotificationOption
                                       {
                                           ProgressBar = true,
                                           PositionClass = "toast-bottom-right",
                                           CloseButton = true
                                       });
            return PartialView(model);

        }


        public async Task<IActionResult> Details(int id)
        {
            var studentViewModel = await _studentRecordBL.GetStudentRecordDetailById(id);


            return PartialView(studentViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var studentViewModel = await _studentRecordBL.GetStudentRecordDetailById(id);

           
           
            return PartialView(studentViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(StudentRecord studentRecord)
        {
            if (ModelState.IsValid)
            {
                StudentRecord newStudentRecord = await _studentRecordBL.Delete(studentRecord.Id);

                _clientNotification.AddToastNotification("Successfully Delete",
                                      NotificationType.success,
                                      new ToastNotificationOption
                                      {
                                          ProgressBar = true,
                                          PositionClass = "toast-bottom-right",
                                          CloseButton = true
                                      });
                return RedirectToAction("Index");
            }

            _clientNotification.AddToastNotification("Error Occured",
                                       NotificationType.error,
                                       new ToastNotificationOption
                                       {
                                           ProgressBar = true,
                                           PositionClass = "toast-bottom-right",
                                           CloseButton = true
                                       });

            return View(studentRecord);

        }


    
        public IQueryable<StudentRecord> GetStudentDetailsUsingSP(int cur_p, int rpp)
        {
            var listOfStudentRecords =  _studentRecordBL.GetStudentRecordByStoredProcedure(cur_p, rpp);

            return listOfStudentRecords;
        }
    }
}
