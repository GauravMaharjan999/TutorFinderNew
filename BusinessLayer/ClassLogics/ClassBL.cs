using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modellayer.Models;
using BusinessLayer.BaseRepository;

namespace BusinessLayer.ClassLogics
{
    public class ClassBL : IClassBL
    {
        private readonly IBaseRepository _baseRepository;
        public ClassBL(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<DataResult> Add(ClassViewModel model)
        {

            Class class1 = new Class
            {
                ClassId = model.ClassId,
                ClassName = model.ClassName,
                NoOfSections = model.NoOfSections,
                OderNo = model.OderNo,
                IsActive = model.IsActive,
                AddedOn = DateTime.Now,
                AddedBy = model.AddedBy
                


            };

            var result =  await _baseRepository.Add<Class>(class1);
            return result;
        }

        public async Task<DataResult> Delete(ClassViewModel model)
        {


            var data = await GetClass(model.ClassId);
            data.IsActive = false;
            data.IsDeleted = true;
            data.DeletedBy = model.DeletedBy;
            data.DeletedOn = DateTime.Now;
         

            var result = await _baseRepository.UpdateModel<Class>(data);

            return result;
        }

        public async Task<Class> GetClass(int Id)
        {
            return await _baseRepository.GetDataById<Class>(Id);
        }

        public async Task<DataResult> Update(ClassViewModel model)
        {
            var data = await GetClass(model.ClassId);
            data.ClassName = model.ClassName;
            data.NoOfSections = model.NoOfSections;
            data.OderNo = model.OderNo;
            data.IsActive = model.IsActive;
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedOn = DateTime.Now;
            

            var result =  await _baseRepository.UpdateModel<Class>(data);

            return result;
        }

        public IQueryable<Class> GetAllClasses()
        {
            return _baseRepository.GetAllList<Class>();
        }
    }

}
