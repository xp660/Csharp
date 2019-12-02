using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    public delegate T numberChanger<T>(T n);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            
            numberChanger<int> nc1 = new numberChanger<int>(AddNum);
            numberChanger<int> nc2 = new numberChanger<int>(MultNum);

            nc1(25);
            Console.WriteLine(num);
            nc2(5);
            Console.WriteLine(num);

            Console.ReadLine();
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int p)
        {
            num *= p;
            return num;
        }


    }
}
