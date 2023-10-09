using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementSystem.ApplicationController;
using StudentManagement.Models;
using Modellayer.Models;
using ClientNotifications;
using static ClientNotifications.Helpers.NotificationHelper;

namespace StudentManagement.Areas.Admin.Controllers
{

    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserRoleController : BaseController

    {   

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        private readonly IClientNotification _clientNotification;

        public UserRoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, IClientNotification clientNotification)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            _clientNotification = clientNotification;
        }


        [HttpGet]
        public async Task<List<RoleCheckVM>> getRoleById(string Id)
        {

            IdentityUser user = await userManager.FindByIdAsync(Id);
            var listOfrole = await userManager.GetRolesAsync(user);


            List<RoleCheckVM> rolecheckList = new List<RoleCheckVM>();
            rolecheckList = (from e in listOfrole.ToList()
                                 select new RoleCheckVM
                                 {
                                 
                                     RoleName = e.ToString(),
                                     IsCheck = true,
                                     RoleId=null
                                 }).ToList();
            foreach (var item in rolecheckList)
            {

                var role = await roleManager.FindByNameAsync(item.RoleName);
                item.RoleId = await roleManager.GetRoleIdAsync(role);
            }

            return rolecheckList;

        }


        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            try
            {

                if (TempData.ContainsKey("RoleAssignStatus"))
                {
                    var name = TempData["RoleAssignStatus"].ToString(); // returns "LoginStatus from AccountController" 
                    if (name == "True")
                    {

                        ViewBag.RoleAssignStatus = true;
                    }
                }



                List<UserRoleViewModel> userRoleViewModelList = new List<UserRoleViewModel>();

                foreach (var user in userManager.Users)
                {
                    var userRoleViewModel = new UserRoleViewModel();
                    /*    {
                            UserId = user.Id,
                            UserName = user.Email,
                        };*/

                        userRoleViewModel.UserId = user.Id;
                        userRoleViewModel.UserName = user.Email;

                    var rolesList = await userManager.GetRolesAsync(user);
                    List<RoleCheckVM> rolecheckList = new List<RoleCheckVM>();
                    /*rolecheckList = rolesList.Select(x=>new RoleCheckVM
                                     {
                                         RoleName = x.ToString(),
                                         IsCheck=true,
                                         //RoleId=e
                                     }).ToList();*/
                    rolecheckList = (from e in rolesList.ToList()
                                     select new RoleCheckVM
                                     {
                                         RoleName = e.ToString(),
                                         IsCheck=true,
                                         //RoleId=e
                                     }).ToList();
                    userRoleViewModel.RoleCheckList = rolecheckList;
                    userRoleViewModel.ConcatRoleName = rolecheckList.Count() != 0 ? String.Join(",", rolecheckList.Select(x => x.RoleName)) : "No Role Assigned";
                    //foreach (var role in roleManager.Roles)
                    //{
                    //    var i = 0;
                    //    userRoleViewModel.RoleCheckList[i].RoleId = role.Id;
                    //    if (await userManager.IsInRoleAsync(user, role.Name))
                    //    {
                    //        userRoleViewModel.RoleCheckList[i].IsCheck = true;

                    //    }
                    //    else
                    //    {
                    //        userRoleViewModel.RoleCheckList[i].IsCheck = false;
                    //    }

                    //    i++;
                    //}
                    
                    userRoleViewModelList.Add(userRoleViewModel);


                }

                var result = userRoleViewModelList.OrderBy(x => x.UserName);



                return PartialView(result);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }



        [AllowAnonymous]
        public async Task<GridIndexData> GridIndex()
        {

            try
            {
                GridIndexData gridIndexData = new GridIndexData();


                gridIndexData.curPage = 1;
             

                if (TempData.ContainsKey("RoleAssignStatus"))
                {
                    var name = TempData["RoleAssignStatus"].ToString(); // returns "LoginStatus from AccountController" 
                    if (name == "True")
                    {

                        ViewBag.RoleAssignStatus = true;
                    }
                }



                List<UserRoleViewModel> userRoleViewModelList = new List<UserRoleViewModel>();

                foreach (var user in userManager.Users)
                {
                    var userRoleViewModel = new UserRoleViewModel();
                    /*    {
                            UserId = user.Id,
                            UserName = user.Email,
                        };*/

                    userRoleViewModel.UserId = user.Id;
                    userRoleViewModel.UserName = user.Email;

                    var rolesList = await userManager.GetRolesAsync(user);
                    List<RoleCheckVM> rolecheckList = new List<RoleCheckVM>();
                    /*rolecheckList = rolesList.Select(x=>new RoleCheckVM
                                     {
                                         RoleName = x.ToString(),
                                         IsCheck=true,
                                         //RoleId=e
                                     }).ToList();*/
                    rolecheckList = (from e in rolesList.ToList()
                                     select new RoleCheckVM
                                     {
                                         RoleName = e.ToString(),
                                         IsCheck = true,
                                         //RoleId=e
                                     }).ToList();
                    userRoleViewModel.RoleCheckList = rolecheckList;
                    userRoleViewModel.ConcatRoleName = rolecheckList.Count() != 0 ? String.Join(",", rolecheckList.Select(x => x.RoleName)) : "No Role Assigned";
                    //foreach (var role in roleManager.Roles)
                    //{
                    //    var i = 0;
                    //    userRoleViewModel.RoleCheckList[i].RoleId = role.Id;
                    //    if (await userManager.IsInRoleAsync(user, role.Name))
                    //    {
                    //        userRoleViewModel.RoleCheckList[i].IsCheck = true;

                    //    }
                    //    else
                    //    {
                    //        userRoleViewModel.RoleCheckList[i].IsCheck = false;
                    //    }

                    //    i++;
                    //}

                    userRoleViewModelList.Add(userRoleViewModel);


                }

                var result = userRoleViewModelList.OrderBy(x => x.UserName);



                gridIndexData.dataRow = result;

                gridIndexData.totalRecords = result.Count();

                return gridIndexData;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        [HttpGet]
        public IActionResult Create()
        {
            UserRoleViewModel model = new UserRoleViewModel();
            var UserList = userManager.Users.ToList();
            var RoleList = roleManager.Roles.ToList();
            model.RoleList = RoleList;
            ViewBag.UserSelectList =new SelectList(UserList, "Id", "UserName");
            //ViewBag.RoleSelectList = new SelectList(RoleList, "Id", "Name");
            return PartialView(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(UserRoleViewModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    var user = await userManager.FindByIdAsync(model.UserId);

/*
                    foreach(var item in model.RoleCheckList)
                    {
                        
                        var roles = await userManager.GetRolesAsync(user);


                        foreach (var role  in roles)
                        {
                            await userManager.RemoveFromRoleAsync(user, role);
                        }
                        

                    }*/

                    for (int i = 0; i < model.RoleCheckList.Count; i++)
                    {

                        var role = await roleManager.FindByIdAsync(model.RoleCheckList[i].RoleId);
                        IdentityResult result = null;

                        var isInRole = await userManager.IsInRoleAsync(user,role.Name);
                        if (model.RoleCheckList[i].IsCheck == true && isInRole!=true)
                        {


                            result = await userManager.AddToRoleAsync(user, role.Name);

                       /*     if (result.Succeeded)
                            {

                                TempData["RoleAssignStatus"] = true;
                                ViewBag.Status = "Success";
                                return RedirectToAction("Index");
                            }*/



                        }

                        else if(model.RoleCheckList[i].IsCheck == false && isInRole == true)
                        {
                            await userManager.RemoveFromRoleAsync(user, role.Name);
                        }


                        TempData["RoleAssignStatus"] = true;
                        ViewBag.Status = "Success";
                        _clientNotification.AddToastNotification("Role Assigned",
                                        NotificationType.success,
                                        new ToastNotificationOption
                                        {
                                            ProgressBar = true,
                                            PositionClass = "toast-bottom-right",
                                            CloseButton = true
                                        });
                    }

                }



                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
         /*   RedirectToAction(Create);*/
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(string UserId)
        {
            var user = await userManager.FindByIdAsync(UserId);
            ViewBag.User = user;
            return PartialView(user);
        }


       

    }
}
