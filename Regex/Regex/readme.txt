string[] values = { "111-22-3333", "111-2-3333" };
string pattern = @"^\d{3}-\d{2}-\d{4}$";  //xxx-xx-xxxx 
Regex.IsMatch(value, pattern)

-----------------------------------------------------------
-----------------------------------------------------------
var input = "this is henry henry !";
var pattern = @"\b(\w+)\W(\1)\b";  //(A1) (A1) (B1) (B1)
Match match = Regex.Match(input,pattern);

while(match.Success)
{
     Console.WriteLine("Duplication {0} is match", match.Groups[1]);
     match = match.NextMatch();
}

//match.Groups[0]:henry henry
//match Groups[1]:henry(1)
//match.Groups[2]:henry(2)
-----------------------------------------------------------
-----------------------------------------------------------
string pattern = @"\b\d+\.\d{2}\b";
string replacement = "$$$&";   //$(input)
string input = "total cost: 103.26";
Regex.Replace(input, pattern, replacement)


-----------------------------------------------------------
-----------------------------------------------------------
string input = "1. egg 2. milk 3. coffee";
string pattern = @"\b\d{1,2}\.\s";   //1. 2. 3.
foreach(string item in Regex.Split(input,pattern))
{
  if(!String.IsNullOrEmpty(item))
              
}

-----------------------------------------------------------
-----------------------------------------------------------
MatchCollection matches;
Regex r = new Regex("abc");
matches = r.Matches("abc123abc123abc");

match.Value, match.Index
match.Result("$&, hello henry! ")  //abc, hello henry 


-----------------------------------------------------------
-----------------------------------------------------------
string input = "Born: July 12, 1993";
string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";  //July 12, 1993
Match match = Regex.Match(input, pattern);
if(match.Success)
{
   for(int ctr=0; ctr<match.Groups.Count; ctr++)
     {
        match.Groups[ctr].Value
     }
}

//match.Groups[0]: July 12, 1993
//match.Groups[1]: July
//match.Groups[2]: 12
//match.Groups[3]: 1993