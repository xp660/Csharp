using System;
using System.IO;

namespace IORead
{
    class Program
    {
        private const string FILE_NAME = "test.txt";
        static void Main(string[] args)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist", FILE_NAME);
                Console.ReadLine();
                return;
            }

            using(StreamReader sr = File.OpenText("test.txt"))
            {
                string input;
                while((input=sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                Console.WriteLine("the end of the stream");
                sr.Close();
            }
            Console.ReadLine();

            //FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            //BinaryReader r = new BinaryReader(fs);

            //for(int i=0; i<11; i++)
            //{
            //    Console.WriteLine(r.ReadString());
            //}

            //r.Close();
            //fs.Close();

            //Console.ReadLine();
        }
    }
}
