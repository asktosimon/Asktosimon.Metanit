// Попробовать реализовать 
// https://academy.yandex.ru/posts/osnovnye-vidy-sortirovok-i-primery-ikh-realizatsii

int[] myArray = { 1, 10, 4, 23, 223, 77, 43, 2, 4 };

#region Bublesort
int[] BubleSort(int[] arr)
{
    int[] result = new int[arr.Length - 1];

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            var current = arr[j];
            var next = arr[j + 1];

            /*if (current > next)
            {
                result[j] = arr[j + 1];

                result[j + 1] = arr[j];
            }*/
            result[j] = arr[j];
        }
    }

    return result;
}

Console.WriteLine(string.Join(", ", BubleSort(myArray)));
#endregion

#region Shakersort

#endregion