File.Exists(@"E:\xxxxxx\xxx.xx")
Directory.Exists(@"E:")

string path="."

if(args.Length>0)
	if(Directory.Exists(args[0]))
		path=args[0]


DirectoryInfo dir = new DirectoryInfo(path)
foreach(FileInfo f in dir.GetFiles("*.exe"))
{
     string name = f.Name;
     long size = f.Length;
     DateTime creationTime = f.CreationTime;
     Console.WriteLine("{0, -12:N0} {1, -20:g} {2}", size, creationTime, name);
                
}
