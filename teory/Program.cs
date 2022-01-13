﻿#region PARAMS
void Hay(int num, params string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
};

Hay(1, "GEORG", "LAM");
#endregion

#region REF IN OUT
void Increment(ref int num)
{
    num++;
}

int num = 6;
Increment(ref num);
Console.WriteLine(num);

void Sum(int a, int b, out int sum)
{
    sum = a + b;
}


Sum(1, 3, out int result);

Console.WriteLine(result);
#endregion

#region методы
void PrintPerson(int age, string name, string company = "LG", string st = "test")
{
    Console.WriteLine($"{age}, {name}, {company}, {st}");
}

PrintPerson(age: 33, name: "Andrey", st: "XLEX");

var lan = Languages.ru;

switch (lan)
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
#endregion