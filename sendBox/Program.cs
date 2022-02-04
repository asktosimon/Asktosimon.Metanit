// Task.Run
// Task.Factory.StartNEw
Task<int> task = Task<int>.Run(() => {

    Console.WriteLine("RUN");

    Task.Factory.StartNew(() => {

        Console.WriteLine("START NEW");
    }, TaskCreationOptions.AttachedToParent);

    Console.WriteLine("EXIT RUN");

    return 2;
});

var a = task.Result;
Console.WriteLine(a);
