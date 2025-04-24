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
        delegate void Sum

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
