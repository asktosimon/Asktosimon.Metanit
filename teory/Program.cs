void PrintPerson(int age, string name, string company = "LG", string st = "test")
{
    Console.WriteLine($"{age}, {name}, {company}, {st}");
}

PrintPerson(age: 33, name: "Andrey", st: "XLEX");

var lan = Languages.ru;

switch(lan)
{
    case Languages.ru:
        SayHelloRu();
        break;
    case Languages.en:
        SayHello();
        break;
}

void SayHello()
{
    PrinMessage("Hello World!");
}


void SayHelloRu()
{
    PrinMessage("Привет, мир!");
}

void PrinMessage(string message)
{
    Console.WriteLine(message);
}

enum Languages
{
    ru,
    en
}
