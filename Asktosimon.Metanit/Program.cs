﻿// Попробовать реализовать 
// https://academy.yandex.ru/posts/osnovnye-vidy-sortirovok-i-primery-ikh-realizatsii

int[] myArray = { 1, 10, 4, 23, 223, 77, 43, 2, 4 };

#region Bublesort
int[] BubleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            int temp;

            var current = arr[j];
            var next = arr[j + 1];

            if (current > next)
            {
                temp = arr[j];
                arr[j] = arr[j + 1];

                arr[j + 1] = temp;
            }
        }
    }

    return arr;
}

var resultBubleSort = BubleSort(myArray);
Console.WriteLine(string.Join(", ", resultBubleSort));
#endregion