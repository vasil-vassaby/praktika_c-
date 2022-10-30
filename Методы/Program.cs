// Метод 1

// Console.Clear();

// void Method1() // ничего не принимает, ничего не возвращает
// {
//     Console.WriteLine("Это метод 1 !");
// }
// //Method1();


// // метод 2 (принимает в данном случае 1 аргумент, но ничего не возращает)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// //Method2("text");

// // метод 2.1 // если несколько аргументов
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // это инкремент (увелечение переменной i на 1), ещё есть декремент (обратный декременту) - count--;
//     }
// }
// //Method21(msg: "text", count: 4); // можно использовать именнованные аргументы

// //Method21(count: 3, msg: "new text"); //если используем именованные аргументы, то можно их указывать не по порядку

// // метод 3 (ничего не принимает, что-то возращает) ОБЯЗАТЕЛЬНО УКАЗЫВАЕМ ТИП ДАННЫХ 
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// //Console.WriteLine(year);

// // метод 4 (что-то принимает, что-то возращает) ОБЯЗАТЕЛЬНО УКАЗЫВАЕМ ТИП ДАННЫХ 
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //пустая строка
//     while (i < count)
//     {
//         result = result + text;
//         i++; // это инкремент (увелечение переменной i на 1), ещё есть декремент (обратный инкременту) - i--;
//     }
//     return result;  //возвращаем результат
// }

// string res = Method4(1, "fuck");
// Console.WriteLine(res);

// class Program
// {
//     static int DivideAndRound(double a, double b)
//     {
//         return (int)Math.Round(a / b);
//     }
//     static void WriteNumber(int number)
//     {
//         Console.WriteLine(number);
//     }

//     static void Main()
//     {
//         WriteNumber(DivideAndRound(10.5, 2.1));
//     }
// }

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        var number = 5.5;
        number += 7;
        Console.WriteLine(number);
    }
}