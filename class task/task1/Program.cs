var spiska = new List<string> (){"apple" ,"banana" ,"oreng"};

foreach (var r in spiska)
{
   System.Console.WriteLine(r); 
}
int k=1;
foreach (var r in spiska)
{
   
   System.Console.WriteLine(k++);
}
foreach (var r in spiska)
{
   System.Console.WriteLine(r);
}

spiska.RemoveAt(1);
foreach (var r in spiska)
{
   System.Console.WriteLine(r);
}
var Apple = spiska.Contains("apple");
System.Console.WriteLine(Apple); 



