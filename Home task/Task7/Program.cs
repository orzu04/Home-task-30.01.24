
List<string> values = new List<string>{ "Maruf", "Davron", "Orzu" };
values.Remove("Orzu");
foreach (var name in values)
{
    System.Console.WriteLine(name);
}
