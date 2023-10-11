using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modellayer.Models
{
    [Table("TrainingCourseSyllabus")]
    public  class CourseSyllabus
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int Hours { get; set; }
        public bool IsFree { get; set; }
        public string VideoPath { get; set; }
        public bool IsActive { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int RowTotal { get; set; }

    }
    public class CourseSyllabusViewModel : CourseSyllabus
    {
        public string CourseName { get; set; }
    }
}
