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
        static void Hello() { Console.WriteLine("Доброе утро!"); }
        static void Bye() { Console.WriteLine("Добрый день!"); }
        static void Main(string[] args)
        {
            //2) создание объекта делегата
            ShowText show = Hello;
            ShowText show2 = Bye;
            if (DateTime.Now.Hour <= 12)
            {
                show();
            }
            else
            {
                show2();
            }
        }
    }
}
