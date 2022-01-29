var x = 1;
var y = 2;

Console.WriteLine($"{x}, {y}");
Obj.Swap(ref x, ref y);
Console.WriteLine($"{x}, {y}");
class Obj
{
    public static void Swap(ref int num1, ref int num2)
    {
        var temp = num1;
        num1 = num2;
        num2 = temp;
    }
}

