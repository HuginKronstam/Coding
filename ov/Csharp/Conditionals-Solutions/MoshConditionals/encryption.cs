using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public static class encryption
    {
        static string encrypt = "Dette er en lang streng som skal krypteres";
        static byte[] encryptBytes = Encoding.Unicode.GetBytes(encrypt);
        static string passfrase = "Fullstack2019";
        static byte[] passfraseByteArray = Encoding.Unicode.GetBytes(passfrase);


        static public void Crypt(/*byte[] encryptBytes*/)
        {
            for (int i = 0; i < encryptBytes.Length; i++)
            {
                encryptBytes[i] = (byte)(encryptBytes[i] ^ passfraseByteArray[i%passfraseByteArray.Length]);
            }
            
        }
        static public void Print()
        {
            string converted = Encoding.Unicode.GetString(encryptBytes, 0, encryptBytes.Length);

            Console.WriteLine(converted);
            Console.ReadKey(true);
        }
        
    }
}
