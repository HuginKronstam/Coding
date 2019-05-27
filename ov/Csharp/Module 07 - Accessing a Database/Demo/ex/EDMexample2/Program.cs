using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMexample2
{
    class Program
    {
        static void Main(string[] args)
        {
            EDMExerciseEntities context = new EDMExerciseEntities();

            var names = from s in context.Students
                        where s.Class == 4
                        select s;
            foreach (var sNames in names)
            {
                Console.WriteLine(sNames.Name);
            }

            var hobbies = from s in context.Hobbies
                          where s.HobbyID == 2
                          select s;
            foreach (var kagehat in hobbies)
            {
                Console.WriteLine(kagehat.HobbyPrice);
            }
            Console.ReadKey(true);

            //var teachers = (from s in context.StudentClass
            //                where s.ClassValue != null
            //                select s).ToList();
            //teachers[0].Teacher = "Erik";
            //teachers[1].Teacher = "Poul";
            //context.SaveChanges();

            //var grades = from s in context.Students
            //                 group s by s.StudentClass.ClassValue into sGroup
            //                 select new { StudentClass = sGroup.Key, students = sGroup };
            

            //foreach (var sClass in grades)
            //{
            //    Console.WriteLine(sClass.StudentClass);
            //}
            
            //var grades2 = from s in context.Students
            //              group s by s.StudentClass into sGrades
            //              select new {StudentClass = sGrades.Key, students=sGrades};
            //foreach (var gradesCake in grades2)
            //{
            //    Console.WriteLine("{0}");
            //}
            
            //IQueryable < Students > students = from s in context.Students
            //                                   where s.StudentID < 3
            //                                   select s;
            //foreach (Students s in students)
            //{
            //    s.StudentName();
            //}
            //var hest = from s in context.Students
            //           where s.StudentID < 3
            //           select new { studentName = s.Name, Class = s.Class };
            //foreach (var h in hest)
            //{ Console.WriteLine("Name: {0} Class: {1}", h.studentName, h.Class); }
            //Console.ReadKey(true);


            //foreach (Students s in context.Students)
            //{
            //    Console.WriteLine(s.StudentID);
            //    s.StudentName();
            //}
            //Console.ReadKey(true);
        }
    }
}
