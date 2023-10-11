
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


		public async Task<TrainingCourse> GetCourseById(int id)
		{
			try
			{
				var list = await _baseRepository.GetDataById<TrainingCourse>(id);
				return list;
			}
			catch (Exception ex)
			{

				throw;
			}


		}

	}
}
