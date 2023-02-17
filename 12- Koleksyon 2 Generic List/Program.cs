namespace _12__Koleksyon_2_Generic_List;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        // T-> object türündedir.

        List<int> sayiList = new List<int>();
        sayiList.Add(23);
        sayiList.Add(22);
        sayiList.Add(11);
        sayiList.Add(21);
        sayiList.Add(9);
        sayiList.Add(10);

        List<string> renk = new List<string>();
        renk.Add("Kırmızı");
        renk.Add("Sari");
        renk.Add("Mavi");
        renk.Add("Turuncu");
        renk.Add("Yeşil");
        //Count
        Console.WriteLine("renk sayisi : "+renk.Count);
        Console.WriteLine("sayi sayisi : "+sayiList.Count);
        // foreach ve list for each ile elemanlara erişim
        foreach (var item in sayiList)
            Console.WriteLine(item);
        foreach (var item in renk)
            Console.WriteLine(item);


        sayiList.ForEach(sayi =>Console.WriteLine(sayi));
        renk.ForEach(renki =>Console.WriteLine(renki));
        
        // Listeden sayi çıkarma
        sayiList.Remove(23); // Değeri çıkarmakt
        renk.Remove("Yeşil");

        sayiList.RemoveAt(0); // index ile çıkarmak
        renk.RemoveAt(0);

        //Liste içerisinde Arama yapmak
        if(sayiList.Contains(10))
            Console.WriteLine("10 sayi listesinde bulundu ");

        // Eleman ile indexe erişmek
        Console.WriteLine(renk.BinarySearch("Sari"));

        // Diziyi listeye çevirmek
        string[] hayvanlar = {"Kedi","Köpek","Kuş"};

        List<string> hayvanlist = new List<string>(hayvanlar);

        //Tüm listeyi nasıl temizlerim
        hayvanlist.Clear();

        //Liste içerisinde nesne tutmak
        List<Kullanicilar> KullaniciList =new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim="Ayşe";
        kullanici1.Soyisim="Yıllar";
        kullanici1.Yas=26;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici1.Isim="fatma";
        kullanici1.Soyisim="Özcan";
        kullanici1.Yas=18;

        KullaniciList.Add(kullanici1);
        KullaniciList.Add(kullanici2);

        List<Kullanicilar> yeniListe= new List<Kullanicilar>();

        yeniListe.Add(new Kullanicilar(){
            Isim="Deniz",
            Soyisim = "Halil",
            Yas=11
        });

        foreach (var kullanici in KullaniciList)
        {
            Console.WriteLine("Kullanici Adı: "+kullanici.Isim);
            Console.WriteLine("Kullanici Adı: "+kullanici.Soyisim);
            Console.WriteLine("Kullanici Adı: "+kullanici.Yas);
        }









    }
}

public class Kullanicilar{
    private string isim;
    private string soyisim;
    private int yas;

    public string? Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}