using BOL.DataBaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonEntities
{
    public class StudentModules
    {
        public List<Students>? StudentsList { get; set; }
        public List<Students>? CourseList { get; set; }
    }
}
