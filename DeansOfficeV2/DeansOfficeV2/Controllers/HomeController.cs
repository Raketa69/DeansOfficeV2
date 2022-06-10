using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeansOfficeV2.Models;

namespace DeansOfficeV2.Controllers
{
    public class HomeController : Controller
    {
        DataBase2 dataBase = new DataBase2();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Finish()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            Student student1 = new Student
            {
                Name = student.Name,
                Departament = student.Departament,
                Birth = student.Birth,
                Place = student.Place,
                Adress = student.Adress,
                Phone = student.Phone,
                Comment = student.Comment,
                Passport = student.Passport,
                PassportDate = student.PassportDate,
                Region = student.Region,
                ISBN = student.ISBN,
                Enter = student.Enter,
                DocNumber = student.DocNumber,
                PersonID = student.PersonID,
                NameID = student.NameID,
                Sign = student.Sign
            };
            dataBase.Students.Add(student1);
            dataBase.SaveChanges();
            return RedirectToAction("Finish");
        }

        [HttpGet]
        public ActionResult AddResults()
        {
            Results results = new Results();
            return View(results);
        }
        [HttpPost]
        public ActionResult AddResults(Results results)
        {
            Results results1 = new Results
            {
                Examination = results.Examination,
                DateExam = results.DateExam,
                CourseWork = results.CourseWork,
                SubjectID = results.SubjectID,
                DateWork = results.DateWork
            };
            dataBase.Resultss.Add(results1);
            dataBase.SaveChanges();
            return RedirectToAction("Finish");

        }

        [HttpGet]
        public ActionResult AddSubject()
        {
            Subject subject = new Subject();
            return View(subject);
        }
        [HttpPost]
        public ActionResult AddSubject(Subject subject)
        {
            Subject subject1 = new Subject
            {
                Code = subject.Code,
                CountHours = subject.CountHours,
                SubjectName = subject.SubjectName,
                SubjectID = subject.SubjectID
            };
            dataBase.Subjects.Add(subject1);
            dataBase.SaveChanges();
            return RedirectToAction("Finish");

        }

        [HttpGet]
        public ActionResult AddSpecial()
        {
            Special special = new Special();
            return View(special);
        }
        [HttpPost]
        public ActionResult AddSpecial(Special special)
        {
            Special special1 = new Special
            {
                NameID = special.NameID,
                Specialization = special.Specialization,
                NameSpecial = special.NameSpecial
            };
            dataBase.Specials.Add(special1);
            dataBase.SaveChanges();
            return RedirectToAction("Finish");
        
        }

        [HttpGet]
        public ActionResult AddSkip()
        {
            Skip skip = new Skip();
            return View(skip);
        }
        [HttpPost]
        public ActionResult AddSkip(Skip skip)
        {
            Skip skip1 = new Skip
            {
                Document = skip.Document,
                Out = skip.Out,
                PersonID = skip.PersonID,
                SubjectID = skip.SubjectID
            };
            dataBase.Skips.Add(skip1);
            dataBase.SaveChanges();
            return RedirectToAction("Finish");
        }


    }
}