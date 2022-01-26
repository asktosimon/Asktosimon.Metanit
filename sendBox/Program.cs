using System.Collections.Generic;
var a1 = new string[] { "arp", "live", "strong" };
var a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong"  };

var r = inArray(a1, a2);

Console.WriteLine(String.Join(", ", r));

string[] inArray(string[] array1, string[] array2)
{
    var result = new List<string>();
    var s = String.Join(" ", array2);

    foreach (var a in array1)
    {
        var index = s.IndexOf(a);
        if (index != -1)
        {
            result.Add(a);
        }
    }

    var rArr = result.ToArray();
    Array.Sort(rArr);

    return rArr;
}