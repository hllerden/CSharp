namespace _10_0_Metodlar;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Erişim belirteci geri_donustipi metot_adi (parametreListesi/argüman)
        //{
            //komutlar;
        //}

        int a=2;
        int b=3;

        Console.WriteLine(a+b);
        int result = Topla(a,b);
        Console.WriteLine(result);
       static int Topla(int x, int y)
        {
            return(x+y);
        }

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(result));
        int sonuc2=ornek.ArttırVeTopla(ref a,ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
                Console.WriteLine(a+b);

    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttırVeTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger1+=1;
        return deger1+deger2;


    }

}
