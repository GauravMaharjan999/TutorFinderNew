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
    public class StudentAcademicViewModel 
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int EmployeeId { get; set; }


        [Required]
        public BoardEnum BoardId { get; set; }


        public string BoardName { get; set; }

        [Required]
        public string College { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Percentage should be between 1 to 100")]
        public decimal Percentage { get; set; }

        [Required]
        public string Division { get; set; }
        [ForeignKey("StudentId")]

        public StudentRecord StudentRecord { get; set; }


        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }


    }
}
