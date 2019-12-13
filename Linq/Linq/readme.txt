class Customer
{
   public string Name{ get; set;}
   public string City{ get;set; }
}

class Customer
{
    public string Name{get;set;}
    public string City{get; set;}
}

-------------------------------------------------

int[] numbers ={,};

//1. Query syntax
     var numQuery1 = from num in numbers
                     where num % 2 == 0
                     orderby num
                     select num;
    foreach (var i in numQuery1)
           
//2. Method syntax
     var numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
     foreach (var i in numQuery2)

------------------------------------------------------------------------
 List<Customer> customers = new List<Customer>();
customers.Add(new Customer() { Name = "Jack", City = "Taoyuan" });
customers.Add(new Customer() { Name = "Mark", City = "Kaohsiung" });
customers.Add(new Customer() { Name = "Henry", City = "Taoyuan" });

var queryCustomers = from c in customers
                     group c by c.City into cusGroup
                     where cusGroup.Count() >=2
                     select new { City= cusGroup.Key, Number= cusGroup.Count()};

foreach(var c in queryCustomers)
-----------------------------------------------------------------------------

List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Hunter", ID = 101 });
            employees.Add(new Employee() { Name = "Jack", ID = 102 });

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID=e.ID, PersonCity=c.City };
            foreach(var p in queryJoin)

---------------------------------------------------------------------------
string[] strings = {"",""};
var stringQuery = from s in strings
                 let words = s.Split(' ')
                 from word in words
                 let w = word.ToUpper()
                 select w;

foreach(var s in stringQuery)







