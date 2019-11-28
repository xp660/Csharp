/*  #define DEBUG  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In Main function");
            Function1();
            Console.ReadLine();
        }

        [Obsolete("Don't use Old Method", true)]
        static void Function1()
        {
            MyClass.Message("In Function 1");
            Function2();
        }

        static void Function2()
        {
            MyClass.Message("In Function 2");
            
        }
    }

    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
        
}
