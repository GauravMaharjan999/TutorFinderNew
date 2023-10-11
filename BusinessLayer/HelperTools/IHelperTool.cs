using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.HelperTools
{
   public interface IHelperTool
    {
        Task<int> GetPageSkip(int pq_curPage, int pq_rPP, int totalRecords);
    }
}
