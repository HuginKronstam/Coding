using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {

            int first, second;
            first = 1;
            second = 2;
            int third = 3;
            Console.WriteLine("Here are your numbers {0}, {1}, {2}", first, second, third);
            Console.ReadKey();
            //Console.WriteLine("Please write your name");
            //string input = Console.ReadLine();
            //Console.WriteLine("Your PC name is: {0} And your name is: {1}", Environment.MachineName, input);
            //Console.WriteLine("The following is your network information, Press any key to continue");
            //Console.ReadKey();
            //Console.WriteLine("");
            //String strHostName = string.Empty;
            //// Getting Ip address of local machine...
            //// First get the host name of local machine.
            //strHostName = Dns.GetHostName();
            //Console.WriteLine("Local Machine's Host Name: " + strHostName);
            //// Then using host name, get the IP address list..
            //IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            //IPAddress[] addr = ipEntry.AddressList;

            //for (int i = 0; i < addr.Length; i++)
            //{
            //    Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            //}
            //Console.WriteLine("");
            //Console.WriteLine("The following is the information about your OSversion, press any key to continue");
            //Console.ReadKey();
            //Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
            //Console.WriteLine("");
            //Console.WriteLine("Now, lets play a little game");
            //Console.ReadKey();

            //Console.WriteLine("Write a secret you want noone to know.");
            //string pass = "";
            //do
            //{
            //    ConsoleKeyInfo key = Console.ReadKey(true);
            //    // Backspace Should Not Work
            //    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            //    {
            //        pass += key.KeyChar;
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
            //        {
            //            pass = pass.Substring(0, (pass.Length - 1));
            //            Console.Write("\b \b");
            //        }
            //        else if (key.Key == ConsoleKey.Enter)
            //        {
            //            break;
            //        }
            //    }
            //} while (true);
            //Console.WriteLine(pass);
            Console.WriteLine("The program is finished, have a nice day.");
        }
    }
}
