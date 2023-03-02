using System.Security.Cryptography;

static void Calculate(double x1, double x2, double x3)
{
    x1 = x1/5; x2 = x2/5; x3 = x3/5;
    Console.WriteLine("{0}, {1}, {2}",x1, x2, x3);
}

Console.WriteLine("Введите 3 числа через Enter");
double x1 = double.Parse(Console.ReadLine()); 
double x2 = double.Parse(Console.ReadLine()); 
double x3 = double.Parse(Console.ReadLine());
Calculate(x1, x2, x3);  

