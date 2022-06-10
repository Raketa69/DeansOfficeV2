using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeansOfficeV2.Models
{
    public class Results
    {
        public int ID { get; set; }
        public int Examination { get; set; }
        public string DateExam { get; set; }
        public int CourseWork { get; set; }
        public int SubjectID { get; set; }
        public string DateWork { get; set; }

}
}