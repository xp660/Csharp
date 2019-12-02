public class MyGenericArray<T, K> where T : struct
{
        private T[] array;
	public MyGenericArray(int size)
	public T GetItem(int index)
	public void SetItem(int index, T value)
}
-----------------------------------------------------------
-----------------------------------------------------------
MyGenericArray<char, string> charArray = new MyGenericArray<char, string>(5);

for (int c = 0; c < 5; c++)
charArray.SetItem(c, (char)(c + 65));
charArray.GetItem(c)











