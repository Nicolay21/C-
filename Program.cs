using System;
using myLibrary;    // подключение пространства имен из библиотеки классов

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square_m square = new Square_m ();

            square.Circle(5);
            square.Triangle(5,5,5,0);

        }
    }
}
