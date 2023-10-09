using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementSystem.ApplicationController;
using ClientNotifications;
using static ClientNotifications.Helpers.NotificationHelper;

namespace StudentManagement.Areas.Admin.Controllers
{

    [Area("Admin")]
    [AllowAnonymous]
    public class UserController : BaseController
    {


        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IClientNotification _clientNotification;

        public UserController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager
            , RoleManager<IdentityRole> roleManager
            , IClientNotification clientNotification)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _roleManager = roleManager;
            _clientNotification = clientNotification;
        }


        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use.");
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var users = userManager.Users;

            if (TempData.ContainsKey("CreateUserStatus"))
            {
                var name = TempData["CreateUserStatus"].ToString(); // returns "LoginStatus from AccountController" 
                if (name == "True")
                {

                    ViewBag.CreateUserStatus = true;
                }
            }



            return PartialView(users);

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            UserViewModel model = new UserViewModel();
            var RoleList = _roleManager.Roles.ToList();
            model.RoleList = RoleList;
            return PartialView(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(UserViewModel model)
        {


            if (ModelState.IsValid)
            {
                if (model.RoleCheckList.Where(x => x.IsCheck).ToList().Count() <= 0)
                {
                    ModelState.AddModelError("RoleCheckList", "Please Select Roles");
                    var RoleList123 = _roleManager.Roles.ToList();
                    model.RoleList = RoleList123;
                    return PartialView(model);

                }
                // Copy data from RegisterViewModel to IdentityUser
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {

                    //Assigning role to new user
                    //var user1 = await userManager.FindByIdAsync(model.UserId);
                    var checkedRolesList = model.RoleCheckList.Where(x => x.IsCheck == true).ToList().Select(x => x.RoleName);
                    result = await userManager.AddToRolesAsync(user, checkedRolesList);


                    TempData["CreateUserStatus"] = true;

                    _clientNotification.AddToastNotification("User Created",
                                      NotificationType.success,
                                      new ToastNotificationOption
                                      {
                                          ProgressBar = true,
                                          PositionClass = "toast-bottom-right",
                                          CloseButton = true
                                      });

                    return RedirectToAction("Index", "Userrole", new { area = "Admin" });
                }

                _clientNotification.AddToastNotification("Error Occured",
                                 NotificationType.error,
                                 new ToastNotificationOption
                                 {
                                     ProgressBar = true,
                                     PositionClass = "toast-bottom-right",
                                     CloseButton = true
                                 });

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }


                if (String.Compare(model.Password, model.ConfirmPassword) != 0)
                {
                    ModelState.AddModelError("Password", "Password and confirmation password do not match.");
                    return PartialView(model);
                }



                var RoleList1 = _roleManager.Roles.ToList();
                model.RoleList = RoleList1;

                return PartialView(model);

            }

            var RoleList = _roleManager.Roles.ToList();
            model.RoleList = RoleList;
            return PartialView(model);


        }







        /*       [HttpGet]
               [AllowAnonymous]
               public async Task<IActionResult> Update(string Id)
               {
                   var user = await userManager.FindByIdAsync(Id);


                   var user1 = new UserViewModel
                   {
                       Email = user.UserName,
                       Id = user.Id
                   };

                   return View(user1);
               }




               [HttpPost]
               [AllowAnonymous]
               public async Task<IActionResult> Update(UserViewModel model)
               {
                   var user = await userManager.FindByIdAsync(model.Email);


                   var result = await userManager.DeleteAsync(user);

                   if (result.Succeeded)
                   {
                       return RedirectToAction("Details");

                       ViewBag.Status = "Success";
                   }

                   ViewBag.Status = "";

                   // If there are any errors, add them to the ModelState object
                   // which will be displayed by the validation summary tag helper
                   foreach (var error in result.Errors)
                   {
                       ModelState.AddModelError(string.Empty, error.Description);

                   }

                   return View();

               }*/

        public async Task<IActionResult> Details(string id)
        {


            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                var rolesList = await userManager.GetRolesAsync(user);


                ViewBag.RolesList = rolesList.ToList();
                UserViewModel userViewModel = new UserViewModel
                {
                    Email = user.ToString()
                };

                return View(userViewModel);
            }


            return RedirectToAction("Index", "Userrole", new { area = "Admin" });
        }

        public async Task<IActionResult> Delete(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);


            var user1 = new UserViewModel
            {
                Email = user.UserName,
                Id = user.Id
            };


            return View(user1);

        }


        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Delete(UserViewModel model)
        {
            try
            {
                var user = await userManager.FindByIdAsync(model.Id);

                if (user != null)
                {
                    var result = await userManager.DeleteAsync(user);

                    if (result.Succeeded)
                    {
                        ViewBag.Status = "Success";
                        return RedirectToAction("Index", "UserRole", new { area = "Admin" });


                    }

                    ViewBag.Status = "";

                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);

                    }


                    return RedirectToAction("Index", "Student", new { area = "Admin" });
                }
                ModelState.AddModelError("Id", "Id cannot be found");

                return RedirectToAction("Index", "Student", new { area = "Admin" });


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }






    }
}
