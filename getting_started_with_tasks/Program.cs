
for (var i = 1; i <= 10; i++)
{
    Task.Factory.StartNew(n =>
    {
        Console.WriteLine($"Starting Task {n}");
        Thread.Sleep(1000); // Long running operation
        Console.WriteLine($"Ended Task {n}");
    }, i);


    Console.ReadKey();
}