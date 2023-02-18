using System.Collections;

namespace _12_1_Koleksyon_Array_List;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        ArrayList Liste = new ArrayList();
        ArrayList ListeS = new ArrayList();

        Liste.Add("Ali");
        Liste.Add(2);
        Liste.Add(true);
        Liste.Add('A');

        //içriğe erişim
        Console.WriteLine(Liste[1]);

        foreach (var item in Liste)
            Console.WriteLine(item);

        //Add Range
        Console.WriteLine(" ***** Add Range *****");
        string[] renkler = {"Kırmızı","Sari","Yeşil"};
        List<int> sayilar = new List<int>(){1,8,3,7,9,98,5};
        Liste.AddRange(renkler);
        ListeS.AddRange(sayilar);

        foreach (var item in Liste)
            Console.WriteLine(item);
        // Sort
        Console.WriteLine("***** Sorting *****");
        // Çalıştırmadan hata vermezken çalıştırında hata verecek.
        // iç elemanları farklı olduğu için compire edip karşılaştıramıyor.
         ListeS.Sort();
        foreach (var item in ListeS)
            Console.WriteLine(item);
        // Binary Search
        Console.WriteLine("***** Binary Search *****");
        // kendi içinde önce sıralanması gerekir sonra binary search yapılabilir
        Console.WriteLine(ListeS.BinarySearch(9));

        // Reverse
        Console.WriteLine("***** Reverse *****");
        ListeS.Reverse();
        foreach (var item in ListeS)
            Console.WriteLine(item);

        // Clear
        Console.WriteLine("***** Clear *****");
        ListeS.Clear();
        foreach (var item in ListeS)
            Console.WriteLine(item);


    }
}
