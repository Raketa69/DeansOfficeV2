using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeansOfficeV2.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public int CountHours { get; set; }
        public string SubjectName { get; set; }
        public int SubjectID { get; set; }

    }
}