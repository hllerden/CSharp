namespace _12_2__Dictionary;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("********************");
        //Enumerable.Range(1, 7).ToList().ForEach(Console.Write);       
        //  Enumerable.Range(1, 20).( x=> Console.WriteLine("x"));
        // for (int i = 0; i < 20; i++)
        //   Console.Write("*");        
        // Console.WriteLine("*");
        // 1.To(7).Do(Console.WriteLine);
        // 1.To.20.Do(Console.Write("*"));
        // String.Join(", ", Enumerable.Range(1, 50).Select(x => $"cb{x:00}"));

        // system.collection.generic

        Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
        kullanicilar.Add(1,"Ayşe Fatma Hayriye");
        kullanicilar.Add(2,"Ahmem Mümtaz Taylan");
        kullanicilar.Add(3,"Ali Veli");

        // dizinin elemanlarına erişim

        Console.WriteLine("****** Elemanlara erişim ******");
        //System.Console.WriteLine(kullanicilar[1]);
        foreach (var item in kullanicilar)
            System.Console.WriteLine(item);         
        
        // Count
        Console.WriteLine("****** Count ******");
        System.Console.WriteLine(kullanicilar.Count());

        //Contains aralığı 
        Console.WriteLine("****** Contains ******");
        Console.WriteLine(kullanicilar.ContainsKey(2));
        Console.WriteLine(kullanicilar.ContainsValue("Halil ERDEN"));
        Console.Out.WriteLine("/r/t");

        //Remove
        Console.WriteLine("****** Remove ******");
        kullanicilar.Remove(2);
        foreach (var item in kullanicilar)
            System.Console.WriteLine(item);

        //Keys
        Console.WriteLine("****** Keys ******");
        foreach (var item in kullanicilar)
            System.Console.WriteLine(item.Key);
        //Values
        Console.WriteLine("****** Values ******");
        foreach (var item in kullanicilar)
            System.Console.WriteLine(item.Value);

        Repeat(20, () => Console.Write(" *-* "));
        
        







    }

    public static void Repeat(int count, Action action)
    {
        for (int i = 0; i < count; i++)
        {
            action();
        }
    }
}
