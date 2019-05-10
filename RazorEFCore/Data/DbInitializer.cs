using RazorEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEFCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolStuContext context)
        {
            if (context.Student.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{FirstName="Yan",LastName="li",EnrollmentDate=DateTime.Parse("1992-1-3")},
                new Student{FirstName="Yan",LastName="lin",EnrollmentDate=DateTime.Parse("1997-6-13")},
                new Student{FirstName="lis",LastName="yi",EnrollmentDate=DateTime.Parse("1994-7-30")},
                new Student{FirstName="Wang",LastName="ling",EnrollmentDate=DateTime.Parse("1995-5-9")}
            };
            foreach(Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();
            var courses = new Course[]
{
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
};
            foreach (Course c in courses)
            {
                context.Course.Add(c);
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
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
    }
}
