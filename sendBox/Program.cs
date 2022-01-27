var a = new Man(12);


class Person
{
    protected int ID;

    public Person (int ID)
    {
        this.ID = ID;
        this.ID++;
    }
}

class Man : Person
{

    public Man(int ID) : base (ID)
    {
        this.ID++;
        Console.WriteLine (this.ID);
    }
}