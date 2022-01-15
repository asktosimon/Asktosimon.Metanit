namespace teory
{
    internal class Animal
    {
        public string name = "undefined";

        public Animal(string name)
        {
            this.name = name;
        }

        public void Deconstruct(out string name)
        {
            name = this.name;
        }
    }
}
