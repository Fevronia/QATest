using System;

namespace QaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle();

            Console.WriteLine("Input side x of dot A: ");
            double Ax = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side y of dot A: ");
            double Ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side x of dot B: ");
            double Bx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side y of dot B: ");
            double By = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side x of dot C: ");
            double Cx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side y of dot C: ");
            double Cy = Convert.ToInt32(Console.ReadLine());

            double AB = triangle1.LengtOfSide(Ax, Ay, Bx, By);
            Console.WriteLine("Lenght of side AB: {0}", AB);

            double BC = triangle1.LengtOfSide(Bx, By, Cx, Cy);
            Console.WriteLine("Lenght of side BC: {0}", BC);

            double AC = triangle1.LengtOfSide(Ax, Ay, Cx, Cy);
            Console.WriteLine("Lenght of side AC: {0}", AC);


            triangle1.GetType(AB, BC, AC);
            triangle1.Triangle_Peremeter(AB, BC, AC);
            triangle1.EvenNumbers();

        }
    }
}
