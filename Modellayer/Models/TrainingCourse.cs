using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modellayer.Models
{
  
    public class TrainingCourse
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ProfileImagePath { get; set; }
        public string CoverImagePath { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int Duration { get; set; }
        public string PreRequisites { get; set; }
        [Required]
        public string CourseLevel { get; set; }
        public bool IsShowOnHomePage { get; set; }

        public decimal CourseFee { get; set; }
        public string IntroVideoPath { get; set; }

    }

    public class CourseDetailViewModel
    {
        public TrainingCourse Course { get; set; }
        public TrainingTutor TrainingTutor { get; set; }
        public IEnumerable<CourseSyllabus> CourseSyllabus { get; set; }
        public List<CourseLevel> CourseLevelList { get; set; }
        public List<TrainingCourseCategory> TrainingCourseCategoryList { get; set; }
        public IFormFile ProfileImage { get; set; }
        public IFormFile CoverImage { get; set; }
    }
}
