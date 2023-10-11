using Modellayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models
{
    public class StudentAcademic
    {

        [Key]
        public int StudentAcademicId { get; set; }

        public int StudentId { get; set; }

        [Required]
        public BoardEnum BoardId { get; set; }

        [Required]
        public string College { get; set; }

        [Required]
        public decimal Percentage { get; set; }

        [Required]
        public string Division { get; set; }




        [ForeignKey("StudentId")]
        public StudentRecord StudentRecords { get; set; }

        //public virtual StudentRecord Student { get; set; }



    }
}
