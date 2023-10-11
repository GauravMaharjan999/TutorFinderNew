using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class ClassViewModel
    {
        [Key]
        public int ClassId { get; set; }

        public bool HasSemester { get; set; }

        [Required(ErrorMessage = "Class Name is Required")]
        public string ClassName { get; set; }
        public int? NoOfSections { get; set; }
        public int? OderNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime AddedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string CurrentUserId { get; set; }
    }
}
