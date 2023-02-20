﻿namespace _13_3_Class_stati_ve_üyeler;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayisi : {0}",Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe","Yılmaz","Ik");
        Console.WriteLine("Çalışan Sayisi : {0}",Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Deniz","Arda","Ik");
        Calisan calisan2 = new Calisan("Halil","ERDEN","Ik");
        Console.WriteLine("Çalışan Sayisi : {0}",Calisan.CalisanSayisi);


        Console.WriteLine("Toplama işlemi sonucu : {0}",islemler.Topla(100,200));
        Console.WriteLine("Çıkarma işlemi sonucu : {0}",islemler.Cikar(420,200));


    }
}
///   ÇAlışan sınıfında nesne oluşturduğumda onun public olan constrackı çalışır.
///   Ama çalişan sınıfının static olan constracterı sadece 1 kere çalışır.
///   Static olanın içinde statik olmayana hiçbir eleman kullanamazsınız.
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi=0;

    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim=soyisim;
        this.Departman=departman;
        calisanSayisi++;
    }


}
static class islemler
{
    public static long Topla (int sayi1,int sayi2)
    {return sayi1+sayi2;}
    public static long Cikar (int sayi1,int sayi2)
    {return sayi1-sayi2;}
}