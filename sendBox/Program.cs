var a = Outer();
var b = Outer();

Action Outer()
{
    var x = 0;
    return () =>
    {
        x++;
        Console.WriteLine(x);
    };
}
