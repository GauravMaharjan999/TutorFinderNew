using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.ApplicationController;
using System.Threading.Tasks;

namespace StudentManagement.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DashboardController : BaseController
    {



        public DashboardController()
        {
        }



        //[Route("admin/student/index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }



    }
}
