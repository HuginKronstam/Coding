using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //public delegate void TestDlegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            string fredagsStreng = "Det er fredag og der er næsten sol";

            SimpleMethod();
            

            async void SimpleMethod()
            { 
            Task<string> t = Task.Run<string>(() => 
            { 
            //Parallel.Invoke(() => { Method1("Kage"); },
            //                () => { Method2("Kage"); },
            //                () => { Method3("Kage"); }
            //                );
                return "test";
            });
            Console.WriteLine(await t);
                Console.ReadKey();
            }
            Console.ReadKey();
            Parallel.For(0, 100, (i) => Console.Write(i + " "));
            Parallel.ForEach(fredagsStreng, (f) => Console.Write(f));


            //Task task1 = Task.Run(() => { method1("vi mig noget"); });
            Task task1 = new Task(() => { Method1("kage"); });
            Task task2 = new Task(() => { Method2("kage"); });
            Task task3 = new Task(() => { Method3("kage"); });
            Task[] tasks = new Task[3] { task1, task2, task3 };
            Task.Run(() =>
            {
                foreach (var task in tasks)
                {
                    task.Start();
                }

            }
                    );

            //task1.Wait();
            //Console.WriteLine("test");
            Console.ReadKey();
        }
            public static async void Method1(string x)
            {
                x += " Gurmi";
                Console.WriteLine(x);
                Console.ReadKey();
            }
            public static async void Method2(string x)
            {
                x += " Den glade";
                Console.WriteLine(x);

            }
            public static async void Method3(string x)
            {
                x += " Hest";
                Console.WriteLine(x);
                Console.ReadKey();
            }
    }
}
