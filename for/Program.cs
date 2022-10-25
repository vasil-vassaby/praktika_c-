// цикл FOR


// string Method4(int count, string text)
// {
//     string result = String.Empty; //присваиваем пустую строку
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;  //возвращаем результат
// }

// string res = Method4(4, "fuck");
// Console.WriteLine(res);

//цикл в цикле (на примере таблицы умножения)
// for (int i = 2; i <= 10-1; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text1, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text1.Length; //длина заданного текста
//     for (int i = 0; i < length; i++)
//     {
//         if (text1[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text1[i]}";
//     }
//     return result;
// }
// string newText = Replace(text,' ','|');
// //Console.WriteLine(newText);

// string newText2 = Replace(newText,'к','К');
// //Console.WriteLine(newText2);

// string newText3 = Replace(newText2,'с','С');
// Console.WriteLine(newText3);

//Работа с массивами (сортировка от минимального к максимальному)
int[] arr = { 1, 2, 3, 4, 5, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
//сортировка от минимального к максимальному
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

//сортировка от максимального к минимальному
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

SelectionSort(arr); //метод сортировки
PrintArray(arr); //метод вывода в консоли