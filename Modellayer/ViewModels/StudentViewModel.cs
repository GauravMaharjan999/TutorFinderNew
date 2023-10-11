
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modellayer.Models;
using Modellayer.Models.Enums;
using StudentManagement.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace StudentManagement.ViewModels
{
    public class StudentViewModel
    {

        [Required]
        public int Id { get; set; }



        [Required]
        [Range(1, 999, ErrorMessage = "Roll number should be between 1 to 999")]
        //[Remote(action: "IsRollInUse", controller: "Student", areaName: "Admin", ErrorMessage ="Roll No already exist",HttpMethod ="POST")]
        [BindProperty]
        public int RollNo { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "First Name exceed to 25 char")]
        [StringLength(25)]
        public string FirstName { get; set; }


        [MaxLength(25, ErrorMessage = "Middle Name exceed to 25 char")]
        public string MiddleName { get; set; }



        [Required]
        [MaxLength(25, ErrorMessage = "Last Name exceed to 25 char")]
        public string LastName { get; set; }



        public string ConcatName { get; set; }



        [Required]
        [MaxLength(25, ErrorMessage = "Address exceed to 25 char")]
        public string Address { get; set; }

        [Required]
        [Range(1,10,ErrorMessage ="Range invalid")]
        public int Class { get; set; }


        [Required]
        public BloodGroupEnum? BloodGroup { get; set; }

        [Required]
        [Phone]
        public string MobileNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime, ErrorMessage = "A valid Date or Date and Time must be entered eg. January 1, 2014 12:00AM")]
        public DateTime BirthDate { get; set; }

        [Required]
        public GenderEnum? Gender { get; set; }

        public StudentRecord student{ get; set; }
        public string PageTitle { get; set; }

        public IFormFile PhotoInput { get; set; } //Actual
        public string PhotoPath { get; set; } // Photo path which contains full photo path
        public string Photo { get; set; } //Same as model which contains unique photo name 

        public int EmployeeId { get; set; }
        public List<StudentAcademicViewModel> StudentAcademicList { get; set; }

        public List<Employee> EmployeeList { get; set; }


    }
}
