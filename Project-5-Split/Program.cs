using System.Text.RegularExpressions;

namespace Project_5_Split;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bu Projede bir string ve 1 rakam girilecek.");
        System.Console.WriteLine("İnput : Algoritma,1 Algoritma,22 Algoritmai,90"
                                +"Output: Algoritma Algoritma Algoritma");

        System.Console.Write("İnput : ");
        string giris = Console.ReadLine();
        string s2 = Regex.Replace(giris, @"[^a-zA-Z d]+", String.Empty);
        System.Console.WriteLine(s2);
      
    }
}
