using System;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
            var call = new ServiceOverload();
            call.StopService(true);
            call.StopService(true, "ForthCoffe.SalesService", 1);
            call.StopService(true, "ForthCoffe.SalesService", 2);
            string statusmessage = "test";
            Console.WriteLine(statusmessage);
            bool res = call.IsOnline("kage", out statusmessage);
            Console.WriteLine(res +" "+ statusmessage);
            Console.ReadKey(true);
        }
    }
}
