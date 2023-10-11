using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class UserRoleViewModel
    {
       
        public string UserId { get; set; }
        public List<IdentityRole> RoleList { get; set; }
        public List<IdentityUser> UserList { get; set; }
        public List<RoleCheckVM> RoleCheckList { get; set; }
        public string UserName { get; set; }
        public string ConcatRoleName { get; set; }

    }
    public class RoleCheckVM
    {
        public string RoleId { get; set; }
        public bool IsCheck { get; set; }
        public  string RoleName { get; set; }
    }
}
