namespace _13_0_class_field_metot_erisim;
class Program
{
    static void Main(string[] args)
    {
        // Söz Dizini
        // Class SinifAdi
        //{
        //    [Erişim belirleyici]    [Veri Tipi] Özellikadi:
        //    [Erişim belirleyici]    [Geri Dönüş Tipi] MetotAdi ([ParameterizedThreadStart Listesi])
        //    {
        //        // Metot komutları
        //    }

        //Erişim Belirleyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected



        Calisan calisan1 = new Calisan();
        calisan1.Ad="Ayşe";
        calisan1.SoyAd="Kara";
        calisan1.no=22122021;
        calisan1.Departman="İnsan Kaynaklari";

        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan2.Ad="deniz";
        calisan2.SoyAd="Arda";
        calisan2.no=25646789;
        calisan2.Departman="Satın Alma";

        calisan2.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string SoyAd;
    public int no;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı        : {0}",Ad);
        Console.WriteLine("Çalışan Soy Adı    : {0}",SoyAd);
        Console.WriteLine("Çalışan Numarası   : {0}",no);
        Console.WriteLine("Çalışan Departmanı : {0}",Departman);
    }
}
