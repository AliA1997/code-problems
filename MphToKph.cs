using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(ConvertMphToKph(100) == 160.93m);
        Console.WriteLine(ConvertMphToKph(250) == 402.3250m);
    }

    public static decimal ConvertMphToKph(decimal mph)
    {
        /*
          Clarify the problem
          Convert miles per hour to kilometers per hour
          1 mile  is 1.6093 kilometers
          Test i/o
          i: 100 mph
          o: 160.93 kph
          Return decimal for precise calculations compared to a double type that it's only used scientific calculations.
          Performance wise decimal slower than double due to it having more precision.
          Also double type uses hardware floating-point arithmetic
        */

        return mph * 1.6093m;
    }
}

