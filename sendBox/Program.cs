using System.Collections;

string[] people = new string[] { "TOM" };

IEnumerator enumerator = people.GetEnumerator();

while(enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

enumerator.Reset();