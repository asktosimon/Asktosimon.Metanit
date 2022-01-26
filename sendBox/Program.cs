var a = Outer();
var b = Outer();
var c = b(2);

Func<int, int> Outer()
{
    var x = 0;
    return (int d) =>
    {
        x++;
        Console.WriteLine(x);
        return x;
    };
}
