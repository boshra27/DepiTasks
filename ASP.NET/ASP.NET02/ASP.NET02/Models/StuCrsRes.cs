using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Models
{
    public class StuCrsRes
    {
        public int StudentId {  get; set; }
        public int CourseId { get; set; }
        public int Grade {  get; set; }

        public Students Student { get; set; }
        public Courses Course { get; set; }
    }
}
