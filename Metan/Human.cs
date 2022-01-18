namespace Metan
{
    public class Human
    {
        string name;

        public Human(string name)
        {
            this.name = name;
        }

        public void Print() => Console.WriteLine(name);
    }
}