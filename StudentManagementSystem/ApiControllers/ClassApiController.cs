
using StudentManagement.Models;

using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.BaseRepository;
using BusinessLayer.ClassLogics;
using Modellayer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassApiController : ControllerBase

    {
        private readonly IBaseRepository _baseRepository;
        private readonly IClassBL _classBL;


        public ClassApiController(IClassBL classBL)
        {
            _classBL = classBL;
        }



        // GET: api/<ValuesController1>


        [HttpGet("GetAllClasses")]
        public IEnumerable<Class> Get()
        {
            return _classBL.GetAllClasses().ToList();
        }

        // GET api/<ValuesController1>/5
        [HttpGet("GetClass/{id}")]
        public async Task<Class> Get(int Id)
        {
            return await _classBL.GetClass(Id);
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public async Task<DataResult> Post([FromBody] ClassViewModel model)
        {
            if (ModelState.IsValid)

            {
                model.AddedBy = User.Identity.Name;

                var result = await _classBL.Add(model);


                return new DataResult { Message = result.ResultType.ToString() };

            }


            return new DataResult { Message = "Model State Invalid" };
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("UpdateClass/{id}")]
        public async Task<DataResult> Put(int id, [FromBody] ClassViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedBy = User.Identity.Name;
                model.ClassId = id;
                var result = await _classBL.Update(model);

                return new DataResult { Message = result.ResultType.ToString() };

            }

            return new DataResult { Message = string.Join(";", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage)) };
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("DeleteClass/{id}")]
        public async Task<DataResult> Delete(int Id)
        {




            var data = await _classBL.GetClass(Id);

            ClassViewModel data1 = new ClassViewModel();

            data1.ClassId = Id;
            var result = await _classBL.Delete(data1);



            return new DataResult { Message = "Data deleted successfully" };

        }
    }
}
