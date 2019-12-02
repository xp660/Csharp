using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("a:{0}; b:{1}", a, b);
            Console.WriteLine("c:{0}; d:{1}", c, d);

            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            
            Console.WriteLine("a:{0}; b:{1}", a, b);
            Console.WriteLine("c:{0}; d:{1}", c, d);


            Console.ReadLine();
        }

        private static void Swap<T>(ref T lhs,ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    public class MyGenericArray<T> where T : struct
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetTItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }

    }

    //public class SubClass:MyGenericArray<int>
    //{

    //}

    //public class SubGenericClass<T>:MyGenericArray<T> where T : struct
    //{

    //}
}
