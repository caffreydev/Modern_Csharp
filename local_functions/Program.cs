public class Program
{
    public static void Main()
    {
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
        }
        Intro(name);
    }

    public static void Intro(string name)
    {
        Console.WriteLine($"Hi {FormatName()}, how's it going?");

        string FormatName()
        {
            if (name.Contains(' '))
            {
                return name.Split(' ')[0];
            }
            else
            {
                return name;
            }
        }
    }
}