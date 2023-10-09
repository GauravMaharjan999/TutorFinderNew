using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalStudentCount { get; set; }
        public int FemaleStudentCount { get; set; }
        public int MaleStudentCount { get; set; }
        public int OtherStudentCount { get; set; }

    }
}
