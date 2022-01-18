using Metan;
// Попробовать реализовать 
// https://academy.yandex.ru/posts/osnovnye-vidy-sortirovok-i-primery-ikh-realizatsii

var h = new Human("Bob");
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
                myArray[j] = next;

                myArray[j + 1] = current;
            }
        }
    }

    return copiedArray;
}

// Console.WriteLine(string.Join(", ", BubleSort(myArray)));
#endregion

#region ShakerSort
int[] ShakerSort(int[] arr)
{
    int[] myArray = { 1, 10, 4, 23, 223, 77, 43, 2, 4 }; // 1, 2, 4, 4, 10,23, 43, 77, 223

    for (var i = 0; i < myArray.Length - 1; i ++)
    {
        if (i == myArray.Length - 1)
        {
            for (int j = myArray.Length - 1; j < myArray.Length - 1 - i; j++)
            {
                var current = myArray[j];
                var next = myArray[j + 1];
                int temp;
                if (current < next)
                {
                    temp = current;
                    myArray[j] = myArray[j + 1];

                    myArray[j + 1] = temp;
                }
            }
        } else
        {
            for (int j = 0; j < myArray.Length - 1 - i; j++)
            {
                var current = myArray[j];
                var next = myArray[j + 1];
                int temp;
                if (current > next)
                {
                    temp = current;
                    myArray[j] = myArray[j + 1];

                    myArray[j + 1] = temp;
                }
            }
        }
    }

    return myArray;
}

Console.WriteLine(string.Join(", ", ShakerSort(myArray)));
#endregion