﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    class Program
    {
        delegate void TestDelegate(string s);
        delegate int del(int i);
        delegate TResult Func<TArg0, TResult>(TArg0 arg0);


        static void M(string s)
        {
            Console.WriteLine(s);
        }
        
        static void Main(string[] args)
        {
            //DelegateHistory();
            StartThread();
            //Lambda();

            Console.ReadLine();
        }
        
        private static void DelegateHistory()
        {
            TestDelegate testDelA = new TestDelegate(M);

            //C# 2.0
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

            //C# 3.0 Lambda Expression
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };


            testDelA("Hello ,this is a delegate");
            testDelB("This is an anonymous method");
            testDelC("This is a lambda expression");
        }

        private static void StartThread()
        {
            System.Threading.Thread t1 = new System.Threading.Thread
            (delegate () //ref , out不能用 , is 也不能用(無法判斷類型)
            {
                Console.Write("Hello, ");
                Console.WriteLine("World!");
            }
            );
            t1.Start();
        }

        private static void Lambda()
        {
            // () => expression
            del myDelegate = x => x * x;
            Console.WriteLine(myDelegate(5));

            Func<int, bool> myFunc = x => x == 5;
            Console.WriteLine(myFunc(4));
        }

    }
}
