using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deligates.Opgaver;
using System.Threading;
namespace Deligates
{
    public delegate string TestDelegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMethod();
            Console.WriteLine("Jeg blev kaldt efter metoden");

            async void SimpleMethod()
            {
                Task<string> t = Task.Run<string>( () =>
               {

                   Thread.Sleep(2000);
                   return "Moar jeg er færdig";
               });
                Console.WriteLine(await t);
            }
            
            //TestDelegate testDel = new TestDelegate(Opgaver.ReString.DoSomething);
            TestDelegate testDel = (s) => { Console.WriteLine("plx"); return s; };

            testDel += Opgaver.ReString.DoSomething;

            //TestDelegate testDel2 = (s) => { Console.WriteLine(s); };
            //testDel += Opgaver.ReString.DoSomething;
            if (testDel != null)
            {
                testDel("This is a test");
                //Console.WriteLine(testDel("This is a test")) ;

                Console.WriteLine(testDel("This is a test"));

                Console.ReadKey();
            }
        }
    }
}
