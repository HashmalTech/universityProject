using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DataBaseEntities
{
    public class Courses
    {
        public string? coursecode {  get; set; }
        public string? coursename { get; set;}
        public int? crhr { get; set; }
        public int? lechr { get; set;  } 
        public int? labhr { get; set; }
        public int? tuthr { get; set; }
        public int? hshr { get; set; } 
    }
}
