var s = new Spider();

interface ICreature
{
    void Move()
    {
        Console.WriteLine("MOVE ICreature");
    }
}

interface IAnimal
{
    void Move()
    {
        Console.WriteLine("MOVE IAnimal");
    }
}

class Spider : ICreature, IAnimal
{
    // void ICreature.Move() => Console.WriteLine("Dddd");
    // void IAnimal.Move() => Console.WriteLine("Dddd");

    public void Move()
    {
        ((ICreature)this).Move();
    }
}