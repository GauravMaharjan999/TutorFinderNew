using BusinessLayer.BaseRepository;
using BusinessLayer.StudentLogics;
using Microsoft.AspNetCore.Mvc;
using Modellayer.Models;
using Modellayer.Models.Enums;
using StudentManagementSystem.ApplicationController;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CourseController : BaseController
    {

        private readonly ICourseBL _courseBL;
        private readonly IBaseRepository _baseRepository;

        public CourseController(ICourseBL courseBL, IBaseRepository baseRepositoryBL)
        {
            _courseBL = courseBL;
            _baseRepository = baseRepositoryBL; 
        }



        //[Route("admin/student/index")]
        public async Task<IActionResult> Index()
        {
            var result = await _courseBL.GetAllCourses();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                CourseDetailViewModel model = new CourseDetailViewModel();
                model = _courseBL.GetRequiredListToCreateCouse(model);
                return View(model);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseDetailViewModel model)
        {
            var result = await _courseBL.AddCourse(model);
            if (result.ResultType == ResultTypeEnum.Success)
            {
                RedirectToAction("Index");
            }
            else
            {
                model = _courseBL.GetRequiredListToCreateCouse(model);
            }
           
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var result = await _courseBL.GetCourseById(id);
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _courseBL.GetCourseById(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CourseDetailViewModel model)
        {
            var result = await _courseBL.EditCourse(model);
            if (result.ResultType == ResultTypeEnum.Success)
            {
                RedirectToAction("Index");
            }
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _courseBL.GetCourseById(id);
            return View(result);
        }


        private CourseDetailViewModel GetRequiredListToCreateCouse (CourseDetailViewModel model)
        {
            model.TrainingCourseCategoryList = _baseRepository.GetAllList<TrainingCourseCategory>().ToList();
            model.CourseLevelList = new CourseLevel().List();
            return model;
        }

        //[HttpPost]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var result = await _courseBL(id);
        //    return View(result);
        //}




    }
}
