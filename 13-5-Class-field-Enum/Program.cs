namespace _13_5_Class_field_Enum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);

        int sicaklik =22;
        if(sicaklik<=(int)HavaSicakligi.Normal)
        {System.Console.WriteLine("Dışarıya çıkmak için havanin biraz daha isinmasini bekleyelim");}
        else if ((sicaklik>=(int)HavaSicakligi.Sıcak))
        {System.Console.WriteLine("Dışarıya çıkmak için Çok sicka bir gün");}
        else if ((sicaklik>=(int)HavaSicakligi.Normal && sicaklik<(int)HavaSicakligi.Coksicak))
        {System.Console.WriteLine("Hadi dişarıya çıkalım");}



    }

    
}
enum Gunler
    {
        Pazartesi=1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

enum HavaSicakligi
{
    Soguk =5,
    Normal=20,
    Sıcak=25,
    Coksicak=30

}