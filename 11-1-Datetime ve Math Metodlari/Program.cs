namespace _11_1_Datetime_ve_Math_Metodlari;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));

        // Datetime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));//12
        Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
        Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday
        
        Console.WriteLine(DateTime.Now.ToString("MM"));//02
        Console.WriteLine(DateTime.Now.ToString("MMM"));//Feb
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//February

        Console.WriteLine(DateTime.Now.ToString("yy"));//22
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

        // **** MATH KÜTÜPHANESİ ****
        Console.WriteLine(" ****** Math Kütüphanesi ******");
        Console.WriteLine(Math.Abs(-25)); // absoult mutlak alır.
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(10.542));// büyük en küçük tam sayıyı getirir.
        Console.WriteLine(Math.Round(10.542));//   Hangisine daha yakınsa ona yuvarlar
        Console.WriteLine(Math.Floor(10.542));//    küçük en büyük tam sayıyı getirir

        Console.WriteLine(Math.Max(2,6));
        Console.WriteLine(Math.Min(2,6));

        Console.WriteLine(Math.Pow(2,6)); // 2^6 =64 
        Console.WriteLine(Math.Sqrt(9)); // karekök alır 
        Console.WriteLine(Math.Log(9)); // ln9
        Console.WriteLine(Math.Exp(9)); // e^9
        Console.WriteLine(Math.Log10(9)); // log10 9
        






    }
}
