
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.HelperTools
{
    public class HelperTool: IHelperTool 
    {
      /*  public int TotalPage{ get; set; }
        public int rowPerPage { get; set; }
        public int currentPage { get; set; }*/
 

        public HelperTool()
        {
        }

        public async Task<int> GetPageSkip(int pq_curPage, int pq_rPP, int totalRecords)
        {
            int skip = (pq_rPP * (pq_curPage - 1));
            if (skip >= totalRecords)
            {
                pq_curPage = (int)Math.Ceiling(((double)totalRecords) / pq_rPP);
                skip = (pq_rPP * (pq_curPage - 1));
            }

            //condition ? statement 1: statement 2
            skip = skip < 0 ? 0 : skip;
            return skip;
        }

        
        
    }

}
