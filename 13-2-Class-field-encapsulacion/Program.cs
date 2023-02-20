namespace _13_2_Class_field_encapsulacion;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim="Yılmaz";
        ogrenci.Ogrencino=293;
        ogrenci.Sinif=3;

        ogrenci.GetInfoÖgrenci();
        ogrenci.SinifAtlat();
        ogrenci.GetInfoÖgrenci();

        Ogrenci ogrenci1 = new Ogrenci("Deniz","Tekin",554,1);
        ogrenci1.GetInfoÖgrenci();
        ogrenci.SinifDusur();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrencino;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Ogrencino { get => ogrencino; set => ogrencino = value; }
    public int Sinif
     { 
        get => sinif; 
        set 
        {   if(value<=1)
            {
                System.Console.WriteLine("Sinif En Az 1 Olabilir!!");
                sinif=1;
            }
            else
                sinif = value;
        }
     }

    public Ogrenci(string isim, string soyisim, int ogrencino, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void GetInfoÖgrenci()
    {
        System.Console.WriteLine(" ***** Öğrenci Bilgileri *****");
        System.Console.WriteLine("Ögrenci adı        : {0} ",this.Isim);
        System.Console.WriteLine("Ögrenci Soyadı     : {0} ",this.Soyisim);
        System.Console.WriteLine("Ögrenci No         : {0} ",this.Ogrencino);
        System.Console.WriteLine("Ögrenci Sınıfı     : {0} ",this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif= this.Sinif+1;
    }
    
    public void SinifDusur()
    {
        this.Sinif= this.Sinif-1;
    }
}