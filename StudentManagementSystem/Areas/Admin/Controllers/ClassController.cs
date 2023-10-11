
using StudentManagement.ViewModels;
using StudentManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementSystem.ApplicationController;
using BusinessLayer.ClassLogics;
using Modellayer.Models;
using Modellayer.Models.Enums;
using ClientNotifications;
using static ClientNotifications.Helpers.NotificationHelper;

namespace StudentManagement.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassController : BaseController
    {

        private readonly IClassBL _classBL;
        private readonly IClientNotification _clientNotification;
        public ClassController(IClassBL classBL,IClientNotification clientNotification)
        {

            _classBL = classBL;
            _clientNotification = clientNotification;

        }



        [HttpGet]
        public IActionResult Index(int pq_curpage, int pq_rPP, string pq_filter)

            {

            try
            {

                var result = _classBL.GetAllClasses().Where(x => x.IsDeleted == false).ToList();

                GridIndexData gridIndexData = new GridIndexData();


                gridIndexData.curPage = 1;
                gridIndexData.dataRow = result;

                gridIndexData.totalRecords = result.Count() ;

                if (result != null)
                {
                    return PartialView(gridIndexData);
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }

        [HttpGet]
        public GridIndexData GridIndex(int pq_curpage, int pq_rPP, string pq_filter)

       {

            try
            {

                var result = _classBL.GetAllClasses().Where(x => x.IsDeleted == false).ToList();

                GridIndexData gridIndexData = new GridIndexData();


                gridIndexData.curPage = 1;
                gridIndexData.dataRow = result;

                gridIndexData.totalRecords = result.Count();

               
                    return gridIndexData;
                

            }
            catch (Exception ex)
            {

                throw;
            }

           

        }



        [HttpGet]
        public async Task<IActionResult> Create()

        {
            return PartialView();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(ClassViewModel model)
        {

            if (ModelState.IsValid)

            {
                model.AddedBy = User.Identity.Name;

                var result = await _classBL.Add(model);

                if (result.ResultType == ResultTypeEnum.Exception || result.ResultType == ResultTypeEnum.Failed)
                {


                    _clientNotification.AddToastNotification("Error occured",
                                      NotificationType.error,
                                      new ToastNotificationOption
                                      {
                                          ProgressBar = true,
                                          PositionClass = "toast-bottom-right",
                                          CloseButton = true
                                      });
                    return View(result);
                }

                _clientNotification.AddToastNotification("Successfully Created",
                                     NotificationType.success,
                                     new ToastNotificationOption
                                     {
                                         ProgressBar = true,
                                         PositionClass = "toast-bottom-right",
                                         CloseButton = true
                                     });
                return RedirectToAction("Index");
            }


            return PartialView(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)

        {
            try
            {

                var result = await _classBL.GetClass(Id);

                if (result != null)
                {
                    ClassViewModel classViewModel = new ClassViewModel
                    {
                        ClassId = result.ClassId,
                        ClassName = result.ClassName,
                        NoOfSections = result.NoOfSections,
                        OderNo = result.OderNo,
                        IsActive = result.IsActive

                    };
                    return PartialView(classViewModel);
                }


            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(ClassViewModel classViewModel)

        {
            try
            {


                if (ModelState.IsValid)
                {
                    classViewModel.ModifiedBy = User.Identity.Name;
                    var result1 = await _classBL.Update(classViewModel);

                    if (result1.ResultType == ResultTypeEnum.Failed || result1.ResultType == ResultTypeEnum.Exception)
                    {
                        ViewBag.Status = "";
                        return PartialView(classViewModel);
                    }


                    ViewBag.Status = "Success";
                    return RedirectToAction("Index");
                }



            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }


        [HttpGet]
        public async Task<IActionResult> Details(int Id)

        {

            try
            {

                var result = await _classBL.GetClass(Id);

                if (result != null)
                {
                    ClassViewModel classViewModel = new ClassViewModel
                    {

                        ClassId = result.ClassId,
                        ClassName = result.ClassName,
                        NoOfSections = result.NoOfSections,
                        OderNo = result.OderNo,
                        IsActive = result.IsActive

                    };




                    return PartialView(classViewModel);
                }


            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView();

        }



        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {

                var result = await _classBL.GetClass(Id);

                if (result != null)
                {
                    ClassViewModel classViewModel = new ClassViewModel
                    {
                        ClassId = result.ClassId,
                        ClassName = result.ClassName,
                        NoOfSections = result.NoOfSections,
                        OderNo = result.OderNo,
                        IsActive = result.IsActive

                    };
                    return PartialView(classViewModel);
                }


            }
            catch (Exception ex)
            {

                throw;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ClassViewModel classViewModel)
        {


            classViewModel.DeletedBy = User.Identity.Name;
            classViewModel.IsDeleted = true;
            var result = await _classBL.Delete(classViewModel);


            if (result.ResultType == ResultTypeEnum.Failed || result.ResultType == ResultTypeEnum.Exception)
            {
                ViewBag.Status = "";
                return PartialView(classViewModel);
            }

            ViewBag.Status = "Success";
            return RedirectToAction("Index");
        }



    }
}
