using Modellayer.Models.Enums;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models
{
 
    public class StudentRecord
    {


        [Required]
        [Key]
        public int Id { get; set; } //Property declaration

        [Required]
        [Range(1,999,ErrorMessage ="Roll number should be between 1 to 999")]
        public int RollNo { get; set; }

        [Required]
        [StringLength(25)]
        [MaxLength(25,ErrorMessage ="Name cannot exceed more than 25")]
        public string FirstName { get; set; }



        [StringLength(25)]

        [MaxLength(25, ErrorMessage = "Name cannot exceed more than 25")]
        public string MiddleName { get; set; }



        [Required]

        [MaxLength(25, ErrorMessage = "Name cannot exceed more than 25")]
        public string LastName { get; set; }




        [Required]

        [MaxLength(25, ErrorMessage = "Address cannot exceed more than 25")]
        public string Address { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Range invalid")]
        public int Class { get; set; }


        [Required]
        public BloodGroupEnum? BloodGroup { get; set; }

        [Required]
        [Phone(ErrorMessage ="Invalid Format")]
        public string MobileNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        public GenderEnum? Gender { get; set; }


        public string Photo { get; set; }

        public  List<StudentAcademic> StudentAcademic { get; set; }

        //public virtual List<StudentAcademic> StudentAcademic { get; set; } = new List<StudentAcademic>();//detail very important
    }
}
