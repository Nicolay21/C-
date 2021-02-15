using System;

namespace myLibrary
{
    public class Square_m
    {
        public void Circle(double rad) // площадь круга
        {
            double pi = Math.PI;
            double squ;

            squ = pi * rad * rad;
            
            Console.WriteLine("Площадь круга =") ;
            Console.WriteLine(squ);
        }
        public void Triangle(double a_t, double b_t, double c_t, int au = 1) // площадь треугольника
        {
            double per_2 = (a_t + b_t + c_t) / 2;

            double squ = Math.Sqrt(per_2 * (per_2 - a_t) * (per_2 - b_t) * (per_2 - c_t));

            Console.WriteLine("Площадь треугольника =");
            Console.WriteLine(squ);

            if (au == 0)
            {

                if (a_t > b_t && a_t > c_t)
                {
                    double num_1 = a_t * a_t;
                    double num_2 = b_t * b_t + c_t * c_t;
                    if (num_1 == num_2)
                    {
                        Console.WriteLine("Прямоугольный");
                    }
                    else
                    {
                        Console.WriteLine(" Не прямоугольный");
                    }
                }
                else if (b_t > a_t && b_t > c_t)
                {
                    double num_1 = b_t * b_t;
                    double num_2 = a_t * a_t + c_t * c_t;
                    if (num_1 == num_2)
                    {
                        Console.WriteLine("Прямоугольный");
                    }
                    else
                    {
                        Console.WriteLine(" Не прямоугольный");
                    }
                }
                else if (c_t > a_t && c_t > b_t)
                {
                    double num_1 = c_t * c_t;
                    double num_2 = a_t * a_t + b_t * b_t;
                    if (num_1 == num_2)
                    {
                        Console.WriteLine("Прямоугольный");
                    }
                    else
                    {
                        Console.WriteLine(" Не прямоугольный");
                    }
                }
                else
                {
                    Console.WriteLine(" Не прямоугольный");
                }
            }
        }
    }
}

// запрос SQL 
// SELECT `autor`,`book` FROM `values` JOIN `books` ON (values.id_book = books.id_book) JOIN `autors` ON (values.id_autor = autors.id_autor)