abstract class Person
{
    public abstract void Say();
}

class Employee : Person
{
    public override void Say()
    {
        Console.WriteLine("Hello");
    }

    public void Say(string phrase)
    {
        Console.WriteLine(phrase);
    }
}