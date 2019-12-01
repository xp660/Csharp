class IndexedNames()
{
   private string[] nameList = new string[10];	
	public IndexedNames(){}
	public string this[int index]{get{} set{}}
	public int this[string name]{get{} }	

}

public interface ISomeInterface
{
	int this[int index]{get;set;}
}

class IndexerClass : ISomeInterface
{
	private int[] arr = new int[100];
	public int this[int index]{get{} set{}}
}

--------------------------------------------------------------
--------------------------------------------------------------

class Program
{
    static void Main(string[] args)
    {
	var names = new IndexedNames();
	names[]=" ";
	
	names[" "];
     }
}


