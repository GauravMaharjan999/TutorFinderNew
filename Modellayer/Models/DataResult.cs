using Modellayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Modellayer.Models
{
        public class DataResult<T> where T : class
        {
            public ResultTypeEnum ResultType { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
        }
        public class DataResult
        {
            public ResultTypeEnum ResultType { get; set; }
            public string Message { get; set; }
            public int ReturnId { get; set; }
        }
  
}
