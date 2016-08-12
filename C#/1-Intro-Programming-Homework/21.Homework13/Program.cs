using System;

    class Homework13
    {
        static void Main()
        {
        double c = Math.Sqrt(1245);
        Console.WriteLine((int)c);
        DateTime time1 = DateTime.Parse("07.10.2000");
        double d = (c + time1.Day) / 2;
        Console.WriteLine((int)d);
        }
    }

