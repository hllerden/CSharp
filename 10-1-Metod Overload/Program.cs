namespace _10_1_Metod_Overload;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string sayi="999";

        bool sonuc = int.TryParse(sayi,out int outSayi);
        if(sonuc)
        {
            Console.WriteLine("Başarili!!\n Değişen sayi: "+outSayi);
        }
        else{
            Console.WriteLine("BAşarisiz!!");
        }

        Metotlar instance = new Metotlar();
        instance.Topla(4,5,out int toplamSonucu);
        Console.WriteLine(toplamSonucu);
        int ifade=999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir("Ali","Veli");


        //metot İmzasi
        // metod adi + parametre sayisi + parametre

    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam=a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1,string veri2)
    {
        Console.WriteLine(veri1+veri2);
    }


}