namespace _8_donguler_for_loop;
class Program
{
    static void Main(string[] args)
    {   

        //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
        Console.WriteLine("Lutfen bir sayi giriniz:");

        int sayac= int.Parse(Console.ReadLine());
        for(int i=0; i<=sayac;i++)
        {

            if(i%2==1)
                 Console.WriteLine(i);
        }

        int tekToplam = 0;
        int ciftToplam=0;
        for(int i=0;i<=1000 ;i++)
        {   if(i==750)
               { Console.WriteLine("**** i değeri: "+i+" oldugunda donguden cikildi****");
                break;
               }
            if (i%2==1)
                tekToplam+=i;
            else
                ciftToplam+=i;
        }
        Console.WriteLine("Tek Toplam:  "+tekToplam);
        Console.WriteLine("Çift Toplam:  "+ciftToplam);
    }
}
