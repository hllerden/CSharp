namespace _8_2_While_Foreach;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {   
        //While: 1den bailayarak konsoldan girilen sayıya kadar
        Console.WriteLine("Lutfen bir sayi giriniz: ");
        int n =int.Parse(Console.ReadLine());
        int i=1;
        int toplam=0;
        while (i<=n)
        {
            toplam+=i;
            i++;
        }

        Console.WriteLine("Ortalama :"+(toplam/n));

        // 'a' dan 'z' ye kadar tüm harfleri yazdıralım.

        char character = 'a';
        while(character < 'z')
        {
            Console.Write(character+" ");
            character++;
        }

        Console.WriteLine("***** Foreach ***** ");
        string[] arabalar = {"Bmw","Ford","Toyota","Nissan","Pegeout"} ;
        foreach(var item in arabalar)
        {
            Console.WriteLine(item);
        }
        
        int[] arr = {1,2,3,5,};
        int val=arr.Max;



    }
}
