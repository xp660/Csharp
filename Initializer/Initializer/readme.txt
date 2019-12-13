public class StudentName
{    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public StudentName()
        {

        }

        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + ID;
        }

}


public class StudentFrom
{
        public string FirstName { get; set; }
        public string City { get; set; }
}

--------------------------------------------------
---------------------------------------------------
var student1 = new StudentName("MeiMei", "Wang");
var student2 = new StudentName { FirstName = "MeiMei", LastName = "Wang" };
var student3 = new StudentName { ID = 100 };
var student4 = new StudentName("Lu", "Lu") { ID = 101 };

---------------------
var students = new List<StudentName> { new StudentName("Lei", "Lei"), new StudentName("Mei", "Mei") };
            var studentFrom = new List<StudentFrom> {
                new StudentFrom{FirstName="Lei",City="Taoyuan" },
                new StudentFrom{FirstName="Wang",City="kaohsiung" }
            };

            var joinquery = from s in students
                            join f in studentFrom on s.FirstName equals f.FirstName
                            select new { FirstName = s.FirstName, LastName = s.LastName, City = f.City };

            foreach (var j in joinquery)
            {
                Console.WriteLine("{0} {1} {2}", j.FirstName, j.LastName, j.City);
            }

------------------
 var students = new List<StudentName>
            {
                new StudentName{ FirstName="Mei",LastName="Mei",ID=100},
                new StudentName(){FirstName="Lei",LastName="Lei",ID=101 },
                new StudentName("Li","Li"){ID=102},
                null
            };



Dictionary<int, StudentName> studentDic = new Dictionary<int, StudentName>
            {
                {111, new StudentName{ FirstName="Mei",LastName="Mei",ID=100}},
                {112, new StudentName(){FirstName="Lei",LastName="Lei",ID=101 }}
            };


















