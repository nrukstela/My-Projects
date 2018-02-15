using System;

namespace watch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clock's scale is 12 hours");
            Console.WriteLine("Insert hour");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert minute");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Angle between hour and minute arrows " + AngleCalculator.MeasureAngleDegree(h, min) + " degree.");
            Console.ReadLine();
        }
    }
}
