private const string FILE_NAME="test.txt";
if (File.Exists(FILE_NAME))
{
   Console.WriteLine("{0} already exists", FILE_NAME);
   Console.ReadLine();
   return;
}


FileStream fs = new FileStream(FILE_NAME, FileMode.Create);
BinaryWriter w = new BinaryWriter(fs);

for (int i = 0; i < 11; i++){ w.Write("a"); }

w.Close();
fs.Close();

-----------------------------------------------
using (StreamWriter w = File.AppendText("test.txt"))
{
     Log("hehe", w);
     Log("hello mike", w);

     w.Close();
}

-----------------------------------------------------
-----------------------------------------------------
public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry:");
            w.WriteLine(" :{0}", logMessage);

            w.Flush();
        }




















