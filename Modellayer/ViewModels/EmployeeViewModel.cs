using StudentManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Modellayer.Models;
using StudentManagement.Models.Enums;

namespace StudentManagement.ViewModels
{
    public class EmployeeViewModel
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Name exceed to 25 char")]
        public String Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public String Email { get; set; }
        [Required]
        public Dept? Department { get; set; }



        public Employee Employee { get; set; }
        public string PageTitle { get; set; }

     


    }
}
