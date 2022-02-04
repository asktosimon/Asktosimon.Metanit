Thread myThread = new Thread(new ThreadStart(DoSomething));

myThread.Start();

foreach (var i in Enumerable.Range(0, 100))
{
    Console.WriteLine($"{i} ОСНОВНОЙ поток");
}

void DoSomething()
{
    foreach(var i in Enumerable.Range(0, 100))
    {
        Console.WriteLine($"{i} неосновной поток");
        Thread.Sleep(2000);
    }
}