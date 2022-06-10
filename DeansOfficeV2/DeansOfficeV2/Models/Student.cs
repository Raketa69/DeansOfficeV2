using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeansOfficeV2.Models
{
    public class Student
    {
        public int ID {get;set; }
        public string Name { get; set; }
        public string Departament { get; set; } //учебная группа
        public string Birth { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public string Passport { get; set; }
        public string PassportDate { get; set; }
        public string Region { get; set; }
        public string ISBN { get; set; }
        public int Enter { get; set; }
        public string DocNumber { get; set; }
        public int PersonID { get; set; }
        public int NameID { get; set; }
        public string Sign { get; set; }

    }
}