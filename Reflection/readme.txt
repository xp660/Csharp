String s = "Hello Reflection";
Type t = s.GetType();
Console.WriteLine(t.FullName);

//typeName
//Type t2 = Type.GetType("System.String", false, true); //typeName--throwOnError--ignoreCase

//資料型態
//Type t3 = typeof(string);

"Copy method: {0}", t.GetMethod("Copy")  //取一個方法
GetMethods(t, BindingFlags.Public | BindingFlags.Instance);

---------------------------------------------------------------
---------------------------------------------------------------
public static void GetMethods(Type t, BindingFlags f)
{
	MethodInfo[] mi = t.GetMethods(f) //取很多方法
	foreach (MethodInfo m in mi)
	{
		m.Name
	}
}