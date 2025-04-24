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
        /// <summary>
        /// 1) объявляем делегат
        /// </summary>
        delegate void ShowText();
        static void Hello() { Console.WriteLine("Привет"); }
        static void Bye() { Console.WriteLine("пoка"); }
        static void Main(string[] args)
        {
            //2) создание объекта делегата
            ShowText show;
            ShowText show2 = Bye;
            //3) связываем с методом Hello
            show = Hello;
            // 4) вызов метода
            show();
            show2();
        }
    }
}
