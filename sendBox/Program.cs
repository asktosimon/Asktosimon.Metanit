class A
{
    public virtual void Say()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Say()
    {
        Console.WriteLine("B");
    }
}

class C : A
{
    public new void Say()
    {
        Console.WriteLine('C');
    }
}

class D : B
{
    public override void Say()
    {
        Console.WriteLine("D");
    }
}