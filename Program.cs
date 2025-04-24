using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        delegate double Operation(double a, double b);
        private static double Add(double a, double b) { return a+b; }
        private static double Dif(double a, double b) { return a-b; }
        private static double Mul(double a, double b) { return a*b; }
        private static double Div(double a, double b) { return a/b; }

        static void Main(string[] args)
        {
            while (true)
            {
                Operation operation;
                Console.WriteLine("выберите действие:\n1. сумма\n2. разность\n" +
                    "3. умножение\n4. деление\n5. выход из программы");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Введите число от 1 до 5.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("ввдеите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("ввдеите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Operation del = new Operation(Add);
                        Console.WriteLine(del.Invoke(a, b));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ввдеите первое число");
                        a= double.Parse(Console.ReadLine());
                        Console.WriteLine("ввдеите второе число");
                        b = double.Parse(Console.ReadLine());
                        del = new Operation(Dif);
                        Console.WriteLine(del.Invoke(a, b));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("ввдеите первое число");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("ввдеите второе число");
                        b = double.Parse(Console.ReadLine());
                        del = new Operation(Mul);
                        Console.WriteLine(del.Invoke(a, b));
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ввдеите первое число");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("ввдеите второе число");
                        b = double.Parse(Console.ReadLine());
                        del = new Operation(Div);
                        Console.WriteLine(del.Invoke(a, b));
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Введите число от 1 до 5.");
                        break;
                }
            }
        }
    }
}
