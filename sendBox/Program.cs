var a = new Counter { Value = 1 };
var b = new Counter { Value = 2 };

var c = a + b;

Console.WriteLine(c.Value);

class Counter
{
    public int Value { get; set; }

    public static Counter operator + (Counter a, Counter b)
    {
        return new Counter { Value = a.Value + b.Value };
    }
}