using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modellayer.Models
{
    [Table("TrainingTutor")]
   public  class TrainingTutor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string ProfileImagePath { get; set; }
        public string MobileNo { get; set; }
        public string ShortBio { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string Experience { get; set; }
        public string Expertise { get; set; }
        public string LinkedInLink { get; set; }
        public bool IsShowOnHomePage { get; set; }
        public int AddedBy { get; set; }

        
        public DateTime AddedOn { get; set; }

        
        public int ModifiedBy { get; set; }

        
        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        
        public int DeletedBy { get; set; }
        
        public DateTime? DeletedOn { get; set; }

        
        public IFormFile ProfileImageAttachment { get; set; }

        
        public IFormFile EditProfileImageAttachment { get; set; }

        
        public int RowTotal { get; set; }

        public int IdentityUserId { get; set; }
    }
}
