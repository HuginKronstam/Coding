using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMexample
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyEntities context = new DummyEntities();
            foreach (Students s in context.Students)
            {
                Console.WriteLine(s.StudentID);
                s.WriteName();
            }
            context.Students.Add(new Students() { Name = "Johan", Class = "5th grade", Color = "Orange" });
            context.SaveChanges();
            foreach (Students s in context.Students)
            {
                Console.WriteLine(s.StudentID);
                s.WriteName();
            }
            Console.ReadKey(true);

        }
    }
}
