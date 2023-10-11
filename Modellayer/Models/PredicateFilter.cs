using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modellayer.Models
{
    public class PredicateFilter
    {

        public int pq_curpage { get; set; }
        public int pq_rPP { get; set; }

        public string queryName { get; set; }
        public string queryMobileNumber { get; set; }
        public string queryAddress { get; set; }
        public int queryRollNo { get; set; }
        public string queryClass { get; set; }
        public string queryBloodGroup { get; set; }
        public string queryGender { get; set; }
        public string queryBirthDate { get; set; }
        public string pq_filter { get; set; }



    }
    public class Datas
    {
        public string dataIndx { get; set; }
        public string value { get; set; }
        public string condition { get; set; }
        public string dataType { get; set; }
        public string cbFn { get; set; }
    }
    public class PQ
    {
        public string mode { get; set; }
        public List<Datas> data { get; set; }

    };
}
