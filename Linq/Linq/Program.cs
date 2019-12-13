using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicConcept();
            //QuerySyntax();
            QueryOperations();



            Console.ReadLine();
        }

        private static void BasicConcept()
        {
            // Linq: Language Intergrated Query
            // select id, name from tablename
            // IEnumerable
            // LINQ to SQL, LINQ to DataSet, LINQ to Objects

            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //1. Query syntax
            var numQuery1 = from num in numbers
                            where num % 2 == 0
                            orderby num
                            select num;

            foreach (var i in numQuery1)
            {
                Console.Write(i + " ");
            }

            //2. Method syntax
            var numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            Console.WriteLine();
            foreach (var i in numQuery2)
            {
                Console.Write(i + " ");
            }

            
        }

        private static void QuerySyntax()
        {
            //1. Data Source
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            //2. Query creation
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            int numCount = numQuery.Count();

            //numQuery.ToList();
            //numQuery.ToArray();
            

            //3. Query exection
            foreach (var num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }

        private static void QueryOperations()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

            var query = from num in numbers
                        where num % 2 == 1 || num % 3 == 1
                        orderby num descending
                        select num;

            foreach(var num in query)
            {
                Console.Write("{0} ",num);
            }

            Console.WriteLine();

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Jack", City = "Taoyuan" });
            customers.Add(new Customer() { Name = "Mark", City = "Kaohsiung" });
            customers.Add(new Customer() { Name = "Henry", City = "Taoyuan" });

            var queryCustomers = from c in customers
                                group c by c.City into cusGroup
                                where cusGroup.Count() >=2
                                select new { City= cusGroup.Key, Number= cusGroup.Count()};

            foreach(var c in queryCustomers)
            {
                Console.WriteLine("{0} Count {1}", c.City, c.Number);
            }


            foreach (var cg in queryCustomers)
            {
                Console.WriteLine(cg.Key);
                foreach (var c in cg)
                {

                    Console.WriteLine(" {0}", c.Name);
                }
            }

            Console.WriteLine();

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Hunter", ID = 101 });
            employees.Add(new Employee() { Name = "Jack", ID = 102 });

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID=e.ID, PersonCity=c.City };
            foreach(var p in queryJoin)
            {
                Console.WriteLine("{0} {1} {2}", p.PersonName, p.PersonID, p.PersonCity);
            }

            Console.WriteLine();

            string[] strings = { "Hello Henry.", "This is Friday!", "Are you Happy?" };
            var stringQuery = from s in strings
                              let words = s.Split(' ')
                              from word in words
                              let w = word.ToUpper()
                              select w;

            foreach(var s in stringQuery)
            {
                Console.WriteLine("{0} ", s);
            }

            

        }

        class Customer
        {
            public string Name
            {
                get;
                set;
            }
            public string City
            {
                get;
                set;
            }


        }

        class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }

    }
}
