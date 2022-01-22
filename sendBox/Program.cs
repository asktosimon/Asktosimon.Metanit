class Rectangle
{
    int a;
    int b;

    int Square()
    {
        return (a * b);
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int x)
    {
        a = x;
        b = x;
    }

    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}