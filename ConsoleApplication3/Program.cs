using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            Double S = 0.0, R = 0.0, a = 0.0, b = 0.0, c = 0.0;
            try
            {
                Console.WriteLine("Выберите тип фигуры:\n1. Круг\n2. Треугольник\n0 - Выход");
                x = Convert.ToInt32(Console.ReadLine());
                CalculateSquare Square = new CalculateSquare();
                while (x != 0)
                {
                    if (x == 1)
                    {
                        Console.WriteLine("Введите радиус круга");
                        R = Convert.ToDouble(Console.ReadLine());
                        S = Square.Circle(R);
                        Console.WriteLine("Площадь круга: " + S);
                        Console.ReadLine();
                        x = -1;
                    }

                    if (x == 2)
                    {
                        Console.WriteLine("Введите длины cторон треугольника через энтер");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        c = Convert.ToDouble(Console.ReadLine());
                        S = Square.Triangle(a, b, c);
                        Console.WriteLine("Площадь треугольника: " + S);
                        Console.ReadLine();
                        x = -1;
                    }

                    if (x <= 0 || x > 2)
                    {
                        Console.WriteLine("Выберите тип фигуры:\n1. Круг\n2. Треугольник\n0 - Выход");
                        x = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Для ввода допустимы только цифры. Приложение будет закрыто!");
                Console.ReadLine();
            }
        }
    }
}
