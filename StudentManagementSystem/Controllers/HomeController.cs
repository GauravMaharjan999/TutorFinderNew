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


namespace StudentManagementSystem.Controllers
{

    public class HomeController : BaseController
    {

        /* private IStudentRecordBL _studentRecordBL;*/
        private IBaseRepository _baseRepository;

        public HomeController()
        {
        }
        // GET: Dashboard
        public async Task<ActionResult> Index()
        {
            return View();
        }


    }
}
