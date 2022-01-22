var pen = new Pen() { color = "Синий", cost = 100 };
Console.WriteLine(pen.color);
class Pen
{
    public string color;
    public int cost;

    public Pen()
    {
        color = "Черный";
        cost = 100;
    }

    public Pen(string color, int cost)
    {
        this.color = color;
        this.cost = cost;
    }
}