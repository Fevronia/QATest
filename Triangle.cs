using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaTest
{
    class Triangle
    {
        public double Perimeter;

        public double LengtOfSide(double x1, double y1, double x2, double y2)
        {
            double SideLenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return SideLenght;

        }


        public void GetType(double a, double b, double c)
        {
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Triangle is equal");
            }
            else
            {
                Console.WriteLine("Triangle is not equal");
            }

            if (a == b || b == c || c == a)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is not Isosceles");

            }
            //if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            if (Math.Pow(b, 2) - (Math.Pow(a, 2) + Math.Pow(c, 2)) <= 1)
            {
                Console.WriteLine("Triangle is Right");
            }
            else
            {
                Console.WriteLine("Triangle is not Right");

            }

        }

        public double Triangle_Peremeter(double a, double b, double c)
        {
            Perimeter = a + b + c;
            Console.WriteLine("Peremetr is {0}", Perimeter);
            return Perimeter;
        }
        public void EvenNumbers()
        {
            Console.WriteLine("Even numbers in range from 0 to triangle perimeter - {0}", Perimeter);

            for (int i = 0; i <= Perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}
