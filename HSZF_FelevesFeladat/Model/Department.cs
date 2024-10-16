using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZF_FelevesFeladat.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public string HeadOfDepartment { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
