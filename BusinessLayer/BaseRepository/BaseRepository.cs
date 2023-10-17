using Microsoft.EntityFrameworkCore;
using Modellayer.Models;
using Modellayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BusinessLayer.BaseRepository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly AppDbContext context;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }

       
     
        public virtual async Task<DataResult> Add<T1>(T1 model) where T1 : class
        {
            try
            {
                context.Set<T1>().Add(model);
                //context.T1.Add(model);
                context.SaveChanges();
                return new DataResult { ResultType = ResultTypeEnum.Success, Message = "Data Saved Successfully" };
            }
            catch (Exception ex)
            {

                return new DataResult { ResultType = ResultTypeEnum.Exception, Message = ex.Message.ToString() };
            }


        }

        public virtual async Task<DataResult> UpdateModel<T1>(T1 model) where T1 : class
        {

            try
            {
                context.Set<T1>().Update(model);
                context.SaveChanges();
                return new DataResult { ResultType = ResultTypeEnum.Success, Message = "Data Updated Successfully" };

            }
            catch (Exception ex)
            {
                return new DataResult { ResultType = ResultTypeEnum.Exception, Message = ex.Message.ToString() };
            }
         
        }

        public virtual async Task<DataResult> UpdateModelDetails<T1, T2>(T1 model, T2[] model2) where T1 : class where T2: class
        {


            DataResult result=new DataResult();

            /*   try
               {

                   //detail delete
                   context.Set<T2>().RemoveRange(model2);
                   await context.SaveChangesAsync();

                   //model updatehh
                   context.Entry(model).State = EntityState.Detached;
                   context.Set<T1>().Update(model);
                   await context.SaveChangesAsync();



                   result = new DataResult { ResultType = Enums.ResultTypeEnum.Success, Message = "Successfully Updated." };
               }
               catch (Exception ex)
               {
                   result =  new DataResult { ResultType = Enums.ResultTypeEnum.Exception, Message = ex.Message.ToString() };
               }*/


            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {

                    //detail delete
                    context.Set<T2>().RemoveRange(model2);
                    await context.SaveChangesAsync();

                    //model updatehh
                    context.Entry(model).State = EntityState.Detached;
                    context.Set<T1>().Update(model);
                    await context.SaveChangesAsync();


                    dbContextTransaction.Commit();
                    result = new DataResult { ResultType = ResultTypeEnum.Success, Message = "Successfully Updated." };
                }
                catch (DbUpdateException ex)
                {
                    dbContextTransaction.Rollback();
                    result = new DataResult { ResultType = ResultTypeEnum.Exception, Message = ex.Message.ToString() };
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    result = new DataResult { ResultType = ResultTypeEnum.Exception, Message = ex.Message.ToString() };
                }
            }


            return result;

        }


        public virtual async Task<T1> Create<T1>(T1 model) where T1 : class
        {
            try
            {
                context.Set<T1>().Add(model);
                //context.T1.Add(model);
                context.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {

                return null;
            }

        }


        public virtual IQueryable<T1> GetAllList<T1>() where T1 : class
        {
            return context.Set<T1>();
        }
        public virtual async Task<int> GetListCount<T1>() where T1 : class
        {
            return context.Set<T1>().Count();
        }
        public virtual async Task<T1> Update<T1>(T1 model) where T1 : class
        {
            context.Set<T1>().UpdateRange(model);
            context.SaveChanges();
            return (model);
        }

        public virtual async Task<T1> GetDataById<T1>(int Id) where T1 : class
        {
            return context.Set<T1>().Find(Id);
        }

        public virtual async Task<T1> Delete<T1>(int Id) where T1 : class
        {
            var model = await GetDataById<T1>(Id);
            context.Set<T1>().Remove(model);
            context.SaveChanges();
            return model;
        }
        public virtual async Task<DataResult> Remove<T1>(int Id) where T1 : class
        {

            try
            {
                var model = await GetDataById<T1>(Id);
                context.Set<T1>().Remove(model);
                context.SaveChanges();
                return new DataResult { ResultType = ResultTypeEnum.Success, Message = "Data Removed Successfully" };
            }
            catch (Exception ex)
            {

                return new DataResult { ResultType = ResultTypeEnum.Exception, Message = ex.Message.ToString() };
            }
           
        }





    }
}
