﻿namespace _13_4_Class_field_Struct;

// 16 byte a kadar veriler için struct
// 16 byte dan fazlasi için class kullanilmali.
// performans için çok etkiler.
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Dikdörtgen dikdörtgen = new Dikdörtgen();
        dikdörtgen.KisaKenar =3;
        dikdörtgen.UzunKenar=4;

        System.Console.WriteLine("Class alan hesabi :{0}",dikdörtgen.AlanHesapla());

        //Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct();
        Dikdörtgen_Struct dikdörtgen_struct ; // Struck kullanirken new ile yaratmamiza gerek yok
        dikdörtgen_struct.KisaKenar=3;
        dikdörtgen_struct.UzunKenar=4;
        System.Console.WriteLine("Struck alan hesabi :{0}",dikdörtgen_struct.AlanHesapla());


    }
}

class Dikdörtgen
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdörtgen(){KisaKenar=3;UzunKenar=4;}

    public long AlanHesapla()
    {return this.KisaKenar*this.UzunKenar;}

    
}
struct Dikdörtgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
    public Dikdörtgen_Struct(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
        
    }
    public long AlanHesapla()
            {return this.KisaKenar*this.UzunKenar;}

    }