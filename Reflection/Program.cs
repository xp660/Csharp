using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Type
            string s = "Hello Reflection";
            Type t = s.GetType();
            Console.WriteLine(t.FullName);

            Type t2 = Type.GetType("System.String", false, true); //typeName--throwOnError--ignoreCase
            Console.WriteLine(t2.FullName);

            Type t3 = typeof(string);
            Console.WriteLine(t3.FullName);

           // GetMethods(t);
            Console.WriteLine("Copy method: {0}", t.GetMethod("Copy"));  //一個方法
            Console.WriteLine("");
            GetMethods(t, BindingFlags.Public | BindingFlags.Instance);
            //GetFields(), GetProperties() 


            Console.ReadLine();
        }

        public static void GetMethods(Type t, BindingFlags f)
        {
            MethodInfo[] mi = t.GetMethods(f); //很多方法
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("{0}", m.Name);
            }
        }



    }
}
