using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models
{
    public class GridIndexData
    {
        public int totalRecords { get; set; }
        public int curPage { get; set; }
        public dynamic dataRow { get; set; }
    }
}
