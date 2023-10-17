
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Modellayer.Models;
using Modellayer.Models.PredicateBuilder;
using BusinessLayer.BaseRepository;
using BusinessLayer.HelperTools;
using Modellayer.Models.Enums;

using Newtonsoft.Json;

namespace BusinessLayer.StudentLogics
{
    public class CourseBL : ICourseBL

    {

        private readonly AppDbContext context;
        private readonly IBaseRepository _baseRepository;
        private readonly IHelperTool _helperTool;
        private readonly IHostingEnvironment _hostingEnvironment;


        public CourseBL(AppDbContext context, IBaseRepository baseRepository, IHelperTool helperTool
                                , IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            _baseRepository = baseRepository;
            _helperTool = helperTool;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<List<TrainingCourse>> GetAllCourses()
        {
            try
            {
				var list = await _baseRepository.GetAllList<TrainingCourse>().ToListAsync();
				return list;
			}
			catch (Exception ex)
            {

                throw;
            }

            
        }


		public async Task<CourseDetailViewModel> GetCourseById(int id)
		{
			try
			{
                CourseDetailViewModel model = new CourseDetailViewModel();
                model = GetRequiredListToCreateCouse(model);
                model.Course= await _baseRepository.GetDataById<TrainingCourse>(id);
                
                
                
				return model;
			}
			catch (Exception ex)
			{

				throw;
			}


		}

        public async Task<DataResult> AddCourse(CourseDetailViewModel model)
        {
            try
            {
                string uniqueFileName = null;
                if (model.ProfileImage   != null)
                {

                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "/Course/ProfileImages/");
                    // Check if the directory exists, and if not, create it
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;


                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.ProfileImage.CopyTo(new FileStream(filePath, FileMode.Create));

                    /*
                     Global unique identify 
                    Every time we call the guid it returns new unique identifier
                    */
                    model.Course.ProfileImagePath = uniqueFileName;
                }

                if (model.CoverImage != null)
                {

                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "/Course/CoverImages/");
                    // Check if the directory exists, and if not, create it
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.CoverImage.FileName;


                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.CoverImage.CopyTo(new FileStream(filePath, FileMode.Create));

                    /*
                     Global unique identify 
                    Every time we call the guid it returns new unique identifier
                    */
                    model.Course.CoverImagePath = uniqueFileName;
                }


                var list = await _baseRepository.Add<TrainingCourse>(model.Course);
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public CourseDetailViewModel GetRequiredListToCreateCouse(CourseDetailViewModel model)
        {
            model.TrainingCourseCategoryList = _baseRepository.GetAllList<TrainingCourseCategory>().ToList();
            model.CourseLevelList = new CourseLevel().List();
            return model;
        }


        public async Task<DataResult> EditCourse(CourseDetailViewModel model)
        {
            try
            {
                var previousModel = await GetCourseById(model.Course.Id);

                previousModel = model;
                string uniqueFileName = null;
                if (model.ProfileImage != null)
                {

                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "/Course/ProfileImages/");
                    // Check if the directory exists, and if not, create it
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;


                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.ProfileImage.CopyTo(new FileStream(filePath, FileMode.Create));

                    /*
                     Global unique identify 
                    Every time we call the guid it returns new unique identifier
                    */
                    model.Course.ProfileImagePath = uniqueFileName;
                }
                else
                {
                    model.Course.ProfileImagePath = previousModel.Course.ProfileImagePath;
                }

                if (model.CoverImage != null)
                {

                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "/Course/CoverImages/");
                    // Check if the directory exists, and if not, create it
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.CoverImage.FileName;


                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.CoverImage.CopyTo(new FileStream(filePath, FileMode.Create));

                    /*
                     Global unique identify 
                    Every time we call the guid it returns new unique identifier
                    */
                    model.Course.CoverImagePath = uniqueFileName;
                }
                else
                {
                    model.Course.CoverImagePath = previousModel.Course.CoverImagePath;

                }

                var list = await _baseRepository.UpdateModel<TrainingCourse>(model.Course);
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public async Task<DataResult> DeleteCourse(CourseDetailViewModel model)
        {
            try
            {

                var result = await _baseRepository.Remove<TrainingCourse>(model.Course.Id);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }


        }



    }
}
