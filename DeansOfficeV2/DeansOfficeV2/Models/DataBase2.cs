using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DeansOfficeV2.Models
{        public class DataBase2 : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Results> Resultss { get; set; }
            public DbSet<Skip> Skips { get; set; }
            public DbSet<Special> Specials { get; set; }

        }
    public class DbInitializer : DropCreateDatabaseAlways<DataBase2>
    {
        protected override void Seed(DataBase2 context)
        {
            context.Students.Add(new Student
            {
                PersonID = 1,
                Name = "Леха Алексей Алексеевич",
                Departament = "ICS",
                Birth = "12.12.2012",
                Place = "Хмельницкий",
                Adress = "Україна, Одеса, вул. Овідіопольска дорога 33, кв.69",
                Phone = "69-696-69-69",
                Comment = "Чел ты...",
                Passport = "228-69-228-69-288",
                PassportDate = "12.12.2020",
                ISBN = "228-69-69-69-228",
                Enter = 1111111111,
                DocNumber = "777-69",
                Sign = "Магистр",
                NameID = 1,
                Region = "Одеса"
            });
            context.SaveChanges();
        }

    }

}