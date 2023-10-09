using Modellayer.Models;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.ClassLogics
{
    public interface IClassBL
    {

        Task<DataResult> Add(ClassViewModel classViewModel);
        Task<DataResult> Delete(ClassViewModel classViewModel);

        Task<DataResult> Update(ClassViewModel classViewModel);
        Task<Class> GetClass(int Id);
        //Task<IQueryable<Class>> GetAllClasses();

        IQueryable<Class> GetAllClasses();

    }
}
