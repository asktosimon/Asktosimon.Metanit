await DoSomethingAsync();

async Task DoSomethingAsync()
{
    Console.WriteLine("start do something");
    await Task.Run(() => DoElseSomethingAsync());
    Console.WriteLine("end do something");
}

async void DoElseSomethingAsync()
{
    Console.WriteLine("start doing something else");
    await Task.Delay(4000);
    Console.WriteLine("end doing something else");
}