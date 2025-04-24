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
        static void GoodMorning() { Console.WriteLine("Доброе утро!"); }
        static void GoodEvening() { Console.WriteLine("Добрый вечер!"); }
        static void Main(string[] args)
        {
            //2) создание объекта делегата
            ShowText show;
            ShowText show2 = GoodEvening;
            //3) связываем с методом Hello
            show = GoodMorning;
            // 4) вызов метода
            show();
            show2();
        }
    }
}
