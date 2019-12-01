using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly objAssembly;
            objAssembly = Assembly.Load("mscorlib,2.0.0.0,Netrual, b77a5c561934e089 ");

            Type[] types = objAssembly.GetTypes();

            //foreach (var t in types)
            //{
            //    Console.WriteLine(t.Name);
            //}

            objAssembly = Assembly.GetExecutingAssembly();
            Type t = objAssembly.GetType("reflection.Car", false, true);

            //實例化--一開始不知道甚麼類型 用object代替
            object obj = Activator.CreateInstance(t);
            MethodInfo mi = t.GetMethod("IsMoving");

            //不知道回傳甚麼值--用Var
            var isMoving = (bool)mi.Invoke(obj, null); //調用的方法是在實例化obj變量上invoke, invoke的方法具體要甚麼參數
            if (isMoving)
            {
                Console.WriteLine("Is moving");
            }
            else
            {
                Console.WriteLine("Not is moving");
            }

            //System.Emit

            Console.ReadLine();
        }

    }

    public class Car
    {
        public bool IsMoving()
        {
            return true;
        }
    }

}
