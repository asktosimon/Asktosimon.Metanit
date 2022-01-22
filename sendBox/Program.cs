var arr = new int[1] { 0 };
GetString(arr);

Console.WriteLine(arr[0]);


void GetString(in int[] arr)
{
    arr[0] = 3;
}

enum DyasOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};