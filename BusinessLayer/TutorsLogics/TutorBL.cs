
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
    public class TutorBL : ITutorBL

    {

        private readonly AppDbContext context;
        private readonly IBaseRepository _baseRepository;
        private readonly IHelperTool _helperTool;
        private readonly IHostingEnvironment _hostingEnvironment;


        public TutorBL(AppDbContext context, IBaseRepository baseRepository, IHelperTool helperTool
                                , IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            _baseRepository = baseRepository;
            _helperTool = helperTool;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<List<TrainingTutor>> GetAllTutors()
        {
            try
            {
				var list = await _baseRepository.GetAllList<TrainingTutor>().ToListAsync();
				return list;
			}
			catch (Exception ex)
            {

                throw;
            }

            
        }


		public async Task<TrainingTutor> GetTutorById(int id)
		{
			try
			{
				var list = await _baseRepository.GetDataById<TrainingTutor>(id);
				return list;
			}
			catch (Exception ex)
			{

				throw;
			}


		}

	}
}
