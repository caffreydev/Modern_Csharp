// See https://aka.ms/new-console-template for more information
using My;
var name = "";
while (String.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
}
var person = new Person(name);
var webAddress = "";
while (String.IsNullOrWhiteSpace(webAddress) || !webAddress.StartsWith("http"))
{
    Console.WriteLine("What is your desired webaddress?");
    webAddress = Console.ReadLine();
}
Print("Hi");
Console.WriteLine(await new HttpClient().GetAsync(webAddress));

void Print(string text) => Console.WriteLine(text + " " + person.Name + "!");

namespace My
{
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
}