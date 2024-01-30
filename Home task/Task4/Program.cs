
List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
  double s=0;
foreach (var r in numbers)
{
    s += r;
    

}
System.Console.WriteLine($"The average value of all the elements in the list is: {s / numbers.Count}");
