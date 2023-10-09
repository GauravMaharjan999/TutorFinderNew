using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{

    [Authorize(Roles="Admin")]

    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };


                IdentityResult result1 = await roleManager.CreateAsync(identityRole);
                if (result1.Succeeded)
                {
                    ViewBag.Status = "Success";
                    return RedirectToAction("CreateRole");  
                }

                foreach(IdentityError error in result1.Errors)  //Throws error like name already taken
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }

        
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string Id)
        {
            var role = await roleManager.FindByIdAsync(Id);


            if (role == null)
            {
                ViewBag.ErrorMessage = $"Roles with Id = {Id} cannot be found";
                return View("NotFound");
            }
       
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            // Retrieve all the Users
            foreach (var user in userManager.Users)
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. This model
                // object is then passed to the view for display
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }



            return View(model);

        }

        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);

        }
    }
}
