using BusinessLayer.BaseRepository;
using BusinessLayer.StudentLogics;
using ClientNotifications;
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


namespace StudentManagementSystem.Controllers
{

    public class CourseController : BaseController
    {

        private ICourseBL _courseBL;
        private IBaseRepository _baseRepository;

        public CourseController(ICourseBL courseBL)
        {
            _courseBL = courseBL;
        }
		// GET: Dashboard
		public async Task<IActionResult> Index()
		{
			var result = await _courseBL.GetAllCourses();

			return View(result);
		}





		[HttpGet]
		public async Task<IActionResult> Details(int Id)
		{

			try
			{

				var result = await _courseBL.GetCourseById(Id);


			}
			catch (Exception ex)
			{

				throw;
			}

			return View();

		}




	}
}
