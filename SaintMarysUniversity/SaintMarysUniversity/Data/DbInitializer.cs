using System;
using SaintMarysUniversity.Models;
using System.Linq;

namespace SaintMarysUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",Anumber="A00466805",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",Anumber="A004668",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",Anumber="A00466815",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",Anumber="A00467805",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",Anumber="A00468805",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",Anumber="A00566805",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",Anumber="A00666805",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",Anumber="A00766805",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",CourseNumber="MCDA5500",CRN="ABCD",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",CourseNumber="MCDA5501",CRN="AACD",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",CourseNumber="MCDA5502",CRN="ABCE",Credits=3},
            new Course{CourseID=1045,Title="Calculus",CourseNumber="MCDA5503",CRN="ABCF",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",CourseNumber="MCDA5504",CRN="ABCG",Credits=4},
            new Course{CourseID=2021,Title="Composition",CourseNumber="MCDA5505",CRN="ABCH",Credits=3},
            new Course{CourseID=2042,Title="Literature",CourseNumber="MCDA5506",CRN="ABCI",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}

