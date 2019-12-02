using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyGenericArray<int, char> intArary = new MyGenericArray<int, char>(5);
            //for (int c = 0; c < 5; c++)
            //{
            //    intArary.SetItem(c, c * 5);
            //}
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.WriteLine(intArary.GetItem(c));
            //}

            Console.WriteLine();

            MyGenericArray<char, string> charArray = new MyGenericArray<char, string>(5);
            for (int c = 0; c < 5; c++)
            {
                charArray.SetItem(c, (char)(c + 65));
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.GetItem(c) + " ");
            }


            Console.ReadLine();

        }



    }

    //Dictionary
    //class, interface,instance class
    public class MyGenericArray<T, K> where T : struct
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }

}
