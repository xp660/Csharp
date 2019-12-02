private static void Swap<T>(ref T lhs,ref T rhs)
{
     T temp = lhs;
     lhs = rhs;
     rhs = temp;
}

---------------------------------------------------
---------------------------------------------------
public class MyGenericArray<T> where T : struct
{
	public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
}

public class SubClass:MyGenericArray<int>
public class SubGenericClass<T>:MyGenericArray<T> where T : struct














