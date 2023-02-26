namespace Project_8_Integers;
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("n adet ikili sayi giriniz.\n"
                        + "toplamını alan, \neğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran,\n"
                        +" sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.  \n"
                        +"Input : 2 3 1 5 2 5 3 3\n"
                        +" 5 6 7 81");
        
        string str =Console.ReadLine();
        int[] input = str.Split(' ').Select(int.Parse).ToArray();
        for(int i=1;i<input.Count()-1;i++)
        {
            if (input[i]==input[i+1])
                System.Console.Write(input[i]*input[i+1]);
            else    
                 System.Console.Write(input[i]
                 ş.input[i+1]);
        }            
    }
}
