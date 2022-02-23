using System;
namespace StaticKeywordExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double number)
        {
            double F = (number - 32) * .5555;
            Console.WriteLine($"{F}");
            return F;
        }

        public static double CelciusToFahrenheit(double num)
        {
            double C = num * 1.8 + 32;
            Console.WriteLine($"{C}");
            return C;
        }

        public TempConverter()
        {
        }
    }
}
