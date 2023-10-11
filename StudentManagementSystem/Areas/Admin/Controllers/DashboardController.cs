using BusinessLayer.BaseRepository;
using Microsoft.AspNetCore.Mvc;
using Modellayer.Models;
using Modellayer.Models.Enums;
using StudentManagement.Models;

using StudentManagement.ViewModels;
using StudentManagementSystem.ApplicationController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentManagementSystem.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DashboardController : BaseController
    {

        /* private IStudentRecordBL _studentRecordBL;*/
        private IBaseRepository _baseRepository;

        public DashboardController(/*IStudentRecordBL studentRecordBL,*/ IBaseRepository baseRepository)
        {
            /*_studentRecordBL = studentRecordBL;*/
            _baseRepository = baseRepository;
        }
        // GET: Dashboard
        public async Task<ActionResult> Index()
        {

          /*  if (TempData.ContainsKey("LoginStatus"))
            {
                var name = TempData["LoginStatus"].ToString(); // returns "LoginStatus from AccountController" 
                if (name == "True")
                {

                    ViewBag.LoginStatus = true;
                }
            }*/

            var students =  _baseRepository.GetAllList<StudentRecord>();
            var totalStudentCount = await _baseRepository.GetListCount<StudentRecord>();

            DashboardViewModel model = new DashboardViewModel();
            ViewBag.TotalStudentCount = totalStudentCount;
            model.TotalStudentCount = totalStudentCount;


            model.MaleStudentCount = students.Where(x => x.Gender == GenderEnum.Male).Count();
            model.FemaleStudentCount = students.Where(x => x.Gender == GenderEnum.Female).Count();
            model.OtherStudentCount = students.Where(x => x.Gender == GenderEnum.Others).Count();



            return PartialView(model);
        }


    }
}
