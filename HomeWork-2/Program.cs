namespace HomeWork_2;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("***** Patika C# 101 HomeWork 2 *****");
        Console.ResetColor(); // To return colors back
        Console.WriteLine(" 1- Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. ");
        Console.WriteLine(" 2- Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun ");
        Console.WriteLine("    kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran");
        Console.WriteLine(" 3-  Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan  ");
        Console.Write("\n   Lütfen yapmak istediğiniz işlemi seçiniz : ");
        Int16 secim = Convert.ToInt16(Console.ReadLine());

        switch (secim)
        {
            case 1:
            {   EtiketCase1:
                int n=20;
                Console.WriteLine("\n\t Lütfen işlemlerin yapılacağı {0} sayiyi giriniz.",n);
                int[] sayi_dizi = new int[n];
                //int[] sayi_dizi = new int[] {1,7,5,12,4,6,78,20,15,22,14,15,68,45,74,19,16,35,2,9} ;
                List<int> Prime = new List<int>();
                List<int> NotPrime = new List<int>();
                string temp;
                for (int i = 0; i < n; i++)
                {   Etiket1:
                    Console.Write("\t Lütfen {0}. Sayiyi giriniz : ",i+1);
                    temp=Console.ReadLine();
                    //sayi_dizi[i]=Convert.ToInt32(Console.ReadLine());
                   //if(sayi_dizi[i]==null ||sayi_dizi[i]==null)

                   if( Int32.TryParse(temp, out int temp_int) && temp_int>=0)
                    {    sayi_dizi[i]=temp_int;

                        if(IsPrime(temp_int))   
                            Prime.Add(temp_int);
                        else
                            NotPrime.Add(temp_int);
                    }
                    else
                    {   
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("\t Girdiğiniz {0}. Sayi Rakamlardan oluşmalı ve sıfırdan büyük olmalidir. : ",i+1);
                         Console.ResetColor(); // To return colors back
                         goto Etiket1;
                    }
                }
                Prime.Sort();
                NotPrime.Sort();
                //seçim 1 olduğunda çalışacak
                if(secim==1)
                {
                    System.Console.WriteLine("\t\t**** Prime olan sayilar ****\n\t\t");
                    foreach (var item in Prime)
                        System.Console.Write("- {0} ",item);
                    Console.Write("\n\t\t Prime sayilarin eleman sayisi : {0} -- Ortalamasi : {1}\n",Prime.Count,Prime.Average());
                    System.Console.WriteLine("\t\t**** Not Prime olan sayilar ****\n\t\t");                  
                    foreach (var item in NotPrime)
                        System.Console.Write("- {0} ",item);
                    Console.Write("\n\t\t Not Prime sayilarin eleman sayisi : {0} -- Ortalamasi : {1}",NotPrime.Count,NotPrime.Average());
                }
                //seçim 2 olduğunda çalışacak
                if(secim==2)
                {
                    Prime.Reverse();
                    NotPrime.Reverse();
                    int prime_for_caseto2 = (Prime.Count>=3)? 3:Prime.Count;
                    int Notprime_for_caseto2 = (Prime.Count>=3)? 3:Prime.Count;
                    int prime_ort=0;
                    int Notprime_ort=0;


                    System.Console.WriteLine("\t\t**** Prime olan sayilar en büyük üç sayi ****\n\t\t");
                    for (int i = 0; i < prime_for_caseto2; i++)
                    {
                        Console.WriteLine("Prime Dizisi [{0}] : {1}",i,Prime[i]);
                        prime_ort+=Prime[i];
                    }
                    Console.Write("\n\t\t Prime sayilarin en büyük 3 eleman Ortalamasi : {0}\n",(prime_ort));

                    System.Console.WriteLine("\t\t**** Not Prime olan sayilar en büyük üç sayi ****\n\t\t");
                    for (int i = 0; i < Notprime_for_caseto2; i++)
                    {
                        Console.WriteLine(" Not Prime Dizisi [{0}] : {1}",i,NotPrime[i]);
                        Notprime_ort+=NotPrime[i];
                    }
                    Console.Write("\n\t\t Not Prime sayilarin en büyük 3 eleman Ortalamasi : {0}\n",(Notprime_ort));
                    System.Console.WriteLine("Prime ve Not Prime 3 sayilarin ortalamalarını toplamı : "+(prime_ort+Notprime_ort));
                }
                break;   
                 
            }

            case 2:
            {
                goto case 1;

                break;
            }

            case 3:
            {   System.Console.Write("Lütfen Bir veya birden fazla cümle yaziniz : ");
                 Console.ForegroundColor = ConsoleColor.Blue;
                //List<string> harfler = new List<string>{};
                string cumle = Console.ReadLine();
                Console.ResetColor(); // To return colors back
                string[] kelimeler= cumle.Split(" ");
                char[] harfler =cumle.ToCharArray();
                char[] sesliharf=new char[] {'a','e','ı','i','o','ö','u','ü'};
                char[] cümle_sesli = new char[]{};
                foreach (char ses in sesliharf)
                    foreach (char harf in harfler)
                        if(ses==harf)
                            cümle_sesli=cümle_sesli.Append(harf).ToArray();

                System.Console.WriteLine("\t\t**** Cümle içerisindeki sesli harfler ****\n\t\t");                  
                    foreach (var item in cümle_sesli)
                        System.Console.Write("- {0} ",item);
                System.Console.WriteLine("\nCümledeki seski harf sayisi: "+cümle_sesli.Count());

                break;
            }
            
            default:
                break;
        }




    }
    static bool IsPrime(int n)
    {
        if (n > 1)
        {
            return Enumerable.Range(1, n).Where(x => n%x == 0)
                             .SequenceEqual(new[] {1, n});
        }

        return false;
    }
}
