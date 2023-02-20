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


        System.Console.WriteLine("***** Çalışan 1 *****");
        Calisan calisan1 = new Calisan("Ayşe","Kara",112244668,"insan kaynakalari");
        //calisan1.Ad="Ayşe";
        //calisan1.SoyAd="Kara";
        //calisan1.No=22122021;
        //calisan1.Departman="İnsan Kaynaklari";

        calisan1.CalisanBilgileri();
         System.Console.WriteLine("***** Çalışan 2 *****");
        Calisan calisan2 = new Calisan();
        calisan2.Ad="deniz";
        calisan2.SoyAd="Arda";
        calisan2.No=25646789;
        calisan2.Departman="Satın Alma";

        calisan2.CalisanBilgileri();

        System.Console.WriteLine("***** Çalışan 3 *****");
        Calisan calisan3 = new Calisan("HAlil","ERDEN");
        calisan3.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string SoyAd;
    public int No;
    public string Departman;

    public Calisan(string ad , string soyad ,int no,string departman)
    {   
        this.Ad = ad;
        this.SoyAd=soyad;
        this.No = no;
        this.Departman=departman;
    }

    public Calisan(string ad , string soyad )
    {   
        this.Ad = ad;
        this.SoyAd=soyad;
       // this.No = no;
       // this.Departman=departman;
    }

    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı        : {0}",Ad);
        Console.WriteLine("Çalışan Soy Adı    : {0}",SoyAd);
        Console.WriteLine("Çalışan Numarası   : {0}",No);
        Console.WriteLine("Çalışan Departmanı : {0}",Departman);
    }
}
