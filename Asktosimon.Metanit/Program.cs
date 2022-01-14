// Попробовать реализовать 
// https://academy.yandex.ru/posts/osnovnye-vidy-sortirovok-i-primery-ikh-realizatsii

int[] myArray = { 1, 10, 4, 23, 223, 77, 43, 2, 4 }; // 1, 2, 4, 4, 10,23, 43, 77, 223

#region Bublesort
int[] BubleSort(int[] arr)
{
    int[] copiedArray = (int[])arr.Clone();

    for (int i = 0; i < copiedArray.Length - 1; i++)
    {
        for (int j = 0; j < copiedArray.Length - 1 - i; j++)
        {
            var current = copiedArray[j];
            var next = copiedArray[j + 1];

            if (current > next)
            {
                copiedArray[j] = copiedArray[j + 1];

                copiedArray[j + 1] = copiedArray[j];
            }
        }
    }

    return copiedArray;
}

Console.WriteLine(string.Join(", ", BubleSort(myArray)));
#endregion

#region ShakerSort
int[] ShakerSort(int[] arr)
{
    int[] copiedArray = (int[])arr.Clone();

    for (var i = 0; i < copiedArray.Length - 1; i ++)
    {

    }

    return copiedArray;
}

Console.WriteLine(string.Join(", ", ShakerSort(myArray)));
#endregion