

List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
  var numbs = numbers.FindAll(e => e%2==0);
foreach (var r in numbs)
{
    System.Console.Write($"{r} ");
}