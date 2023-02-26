namespace Project_7_FieldCalculator;

public class Üçgen
{
    public void run_Ücgen()
    {
        System.Console.WriteLine(" 1 - Alan Hesapla \n"
                                +" 2 - Hacim Hesapla\n"
                                +" 3 - Çevre Hesapla\n");
        System.Console.Write("İşlemi Seçiniz : ");
        int secim = int.Parse(Console.ReadLine());
        Üçgen üçgen = new Üçgen();
        switch (secim)
        {
            case 1:
                üçgen.AlanHesapla();
                break;
            case 2:
                üçgen.HacimHesapla();
                break;
            case 3:
                üçgen.ÇevreHesapla();
                break;
            
            default:
                break;
        }
    }
    public void AlanHesapla()
    {
        System.Console.Write("Üçgen 'Taban' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Üçgen 'Yükselik' Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
       

        System.Console.WriteLine("Üçgenin Alanı : {0}",(a*b)/2);
    }

    public void HacimHesapla()
    {
        System.Console.Write("Üçgen 'Taban' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Üçgen 'Yükselik' Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
        System.Console.Write("Üçgen 'Derinlik' kenar Uzunluğunu Giriniz : ");
        int c = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Üçgenin Hacmi : {0}",(((a*b)/2)*c));
    }

    public void ÇevreHesapla()
    {
        System.Console.Write("Üçgen 'A' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Üçgen 'B' kenar Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
        System.Console.Write("Üçgen 'C' kenar Uzunluğunu Giriniz : ");
        int c = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Üçgenin Alanı : {0}",a+b+c);
    }
}