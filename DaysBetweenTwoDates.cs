using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        var testDate1 = new DateTime(2024, 1, 1);
        var testDate2 = new DateTime(2024, 1, 2);
        var testDate3 = new DateTime(2024, 2, 1);
        var testDate4 = new DateTime(2024, 3, 1);

        Console.WriteLine(DaysLeft(testDate1, testDate2) == 1);
        Console.WriteLine(DaysLeft(testDate3, testDate4) == 29);

    }

    public static int DaysLeft(DateTime fromDate, DateTime toDate)
    {
        /* 
          Return the number of days between two dates.
          The from date would not less than or equal to the to date.
          Subtract between two dates.
        */
        // Use subtract method to subtract from to date.
        // var daysLeftTS = toDate.Subtract(fromDate);
        // Also can use the subtract operator, also returns a timespan object as well.
        var daysLeftTS = toDate - fromDate;
        // Get the days from the timestamp resulting from the subtract method.
        var daysLeft = daysLeftTS.Days;
        //If the days left is less than 0, return 0.
        if (daysLeft < 0) return 0;
        // Convert double to int.
        return int.Parse(daysLeft.ToString());
    }
}