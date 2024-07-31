
public class Program
{
    public static async Task Main()
    {
        var result = await new HttpClient().GetStringAsync("http://www.andreaangella.com");

        Console.WriteLine(result[0..100]);
    }
}