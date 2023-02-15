namespace _9_1_Dizi_arr_metodlari;
class Program
{
    static void Main(string[] args)
    {
        //sorting method
        int[] sayiDizisi = {23,12,4,5,78,9,2,11,22,11,21,47};
        Console.WriteLine("**** Sirasiz Liste ****");
        foreach (var item in sayiDizisi)          
            Console.WriteLine(item);

        Console.WriteLine("**** Sirali Dizi ****");
        Array.Sort(sayiDizisi);

         foreach (var item in sayiDizisi)          
            Console.WriteLine(item);

        //Clear 
        Console.WriteLine("**** Clear Dizi ****");
        // Sayi dizisi elemanlarını kullanarak ikinici indeksten 
        // itibaren 2 tane elemanı 0'lar
        Array.Clear(sayiDizisi,2,2);
        foreach (var item in sayiDizisi)          
            Console.WriteLine(item);

        // Reverse
        Console.WriteLine("**** Reverse Dizi ****");
        Array.Reverse(sayiDizisi);
        foreach (var item in sayiDizisi)          
            Console.WriteLine(item);
        
        //IndexOf
        Console.WriteLine("**** IndexOf Dizi ****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,78));

        // Resize
        Console.WriteLine("**** Resize Dizi ****");
        Array.Resize<int>(ref sayiDizisi,13);
        sayiDizisi[12]=99;
        foreach (var item in sayiDizisi)          
            Console.WriteLine(item);



    }
}
