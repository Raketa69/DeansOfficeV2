using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeansOfficeV2.Models
{
    public class Skip
    {
        public int ID { get; set; }
        public string Document { get; set; }
        public int Out { get; set; }
        public int PersonID { get; set; }
        public int SubjectID { get; set; }

    }
}