using System;

    class Homework12
    {
        static void Main()
        {
        DateTime time = DateTime.Parse("7.10.2000");
        DateTime time1 = DateTime.Parse("20.04.1994");
        Console.WriteLine(time.Month+time1.Month);
        double a = time.Month;
        double b = time1.Month;
        double c = a / b;
        Console.WriteLine(c);
        
        }
    }

