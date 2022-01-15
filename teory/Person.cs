namespace teory
{
    internal class Person
    {
        public string name = "Ubdefibed";
        public int age;
        public const string type = "Person";

        public void Print()
        {
            Console.WriteLine($"name: {name}, age: ${age}, type: {type}");
        }
    }
}