// Реализуйте метод GetMinX 
// для нахождения такого числа x, при котором 
// кривая, заданная уравнением y(x)=ax2+bx+c, принимает минимальное значение.

// Метод должен принимать неотрицательный коэффициент a, а 
// также произвольные коэффициенты b и c, и, 
// если решение существует, возвращать строковое представление искомого x, 
// а иначе — строку Impossible.
class Program
{
        static string GetMinX(int a, int b, int c)
        {
            string z = a > 0 || (a == 0 && b == 0) ? ((double)(-b) / (2 * a)).ToString() // так можно вернуть строковое представление числа
                                                   : ("Impossible");
            return z;
        }
        static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }
   
}




