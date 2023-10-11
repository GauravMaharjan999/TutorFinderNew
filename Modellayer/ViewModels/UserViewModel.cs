using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Sdk;


namespace StudentManagement.ViewModels
{
    public class UserViewModel 
    {
        
        [Required]
        [EmailAddress]
        [Remote(action: "isemailinuse", controller: "user", areaName: "admin")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        public string Id { get; set; }
        public string UserId { get; set; }
        public List<IdentityRole> RoleList { get; set; }
        public List<RoleCheckVM> RoleCheckList { get; set; }


        public int RoleId { get; set; }


    }

}

