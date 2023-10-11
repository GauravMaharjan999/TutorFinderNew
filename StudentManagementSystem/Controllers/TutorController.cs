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

    public class TutorController : BaseController
    {

        private ITutorBL _tutorBL;
        private IBaseRepository _baseRepository;

        public TutorController(ITutorBL tutorBL)
        {
			_tutorBL = tutorBL;
        }
		// GET: Dashboard
		public async Task<IActionResult> Index()
		{
			var result = await _tutorBL.GetAllTutors();

			return View(result);
		}





		[HttpGet]
		public async Task<IActionResult> Details(int Id)
		{

			try
			{

				var result = await _tutorBL.GetTutorById(Id);

				return View(result);
			}
			catch (Exception ex)
			{

				throw;
			}

		}




	}
}
