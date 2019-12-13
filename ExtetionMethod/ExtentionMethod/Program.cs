using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public enum Grades { F=0, D=1, C=2, B=3, A=4};
    class Program
    {
        static void Main(string[] args)
        {
            //DemoLinq();
            //StringCount();
            var g1 = Grades.F;
            var g2 = Grades.D;
            var g3 = Grades.A;
            Console.WriteLine("First {0} a passing grade ", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade ", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade ", g3.Passing() ? "is" : "is not");
            
            Console.WriteLine();

            Extensions.minPassing = Grades.C;
            Console.WriteLine("First {0} a passing grade ", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade ", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade ", g3.Passing() ? "is" : "is not");

            Console.ReadLine();
        }


        private static void DemoLinq()
        {
            int[] ints = { 10, 45, 15, 19, 21, 36 };

            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                Console.WriteLine("{0} ", i);
            }
        }

        private static void StringCount()
        {
            string s = "this is Tim Speaking!";
            int i = s.WordCount();
            Console.WriteLine("word count of s is {0}", i);

        }


       
    }

     static class StringExtention
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class Extensions
    {
        public static Grades minPassing = Grades.D;

        public static bool Passing(this Grades grade)
        {
            return grade >= minPassing;
        }
    }

}
