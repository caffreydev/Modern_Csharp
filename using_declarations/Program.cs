using System.IO;

public class Program
{
    public static void Main()
    {
        WriteLines("file.txt", new[] { "Line 1", "Line 2" });
    }


    public static void WriteLines(string fileName, string[] lines)
    {
        using var fileStream = new FileStream(fileName, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream);
        foreach (var line in lines)
        {
            streamWriter.WriteLine(line);
        }
    }
}