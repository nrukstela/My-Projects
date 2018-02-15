using System;

namespace watch
{
    public static class AngleCalculator
    {
        private static double FindHourArrow(double h, double min) => h * (360 / 12) + min * 0.5;

        private static double FindMinuteArrow(double min) => min * (360 / 60);

        public static double MeasureAngleDegree(double hour, double minutes)
        { 
            return Math.Abs(FindHourArrow(hour, minutes) - FindMinuteArrow(minutes));
        }
    }
}
