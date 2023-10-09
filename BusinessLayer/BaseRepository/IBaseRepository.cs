using Modellayer.Models;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.BaseRepository
{
    public interface IBaseRepository
    {


        Task<DataResult> Add<T1>(T1 model) where T1 : class;
        Task<DataResult> UpdateModel<T1>(T1 model) where T1 : class;
        Task<DataResult> UpdateModelDetails<T1, T2>(T1 model, T2[] model2) where T1 : class where T2 : class;






        Task<T1> Create<T1>(T1 model) where T1 : class;
        IQueryable<T1>GetAllList<T1>() where T1 : class;
        Task<T1> Update<T1>(T1 model) where T1 : class;
  
        Task<T1> GetDataById<T1>(int Id) where T1 : class;

     
        Task<T1> Delete<T1>(int Id) where T1 : class;
        Task<int> GetListCount<T1>() where T1 : class;

    }
}
