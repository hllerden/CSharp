namespace Project_7_FieldCalculator;

public class Kare
{   
     public void run_Kare()
    {
        System.Console.WriteLine(" 1 - Alan Hesapla \n"
                                +" 2 - Hacim Hesapla\n"
                                +" 3 - Çevre Hesapla\n");
        System.Console.Write("İşlemi Seçiniz : ");
        int secim = int.Parse(Console.ReadLine());
        Kare kare = new Kare();
        switch (secim)
        {
            case 1:
                kare.AlanHesapla();
                break;
            case 2:
                kare.HacimHesapla();
                break;
            case 3:
                kare.ÇevreHesapla();
                break;
            
            default:
                break;
        }

    }
    
    public void AlanHesapla()
    {
        System.Console.Write("Karenin Tek kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Karenin Alanı : {0}",a*a);
    }

    public void HacimHesapla()
    {
        System.Console.Write("Karenin Tek kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Karenin Hacmi : {0}",(a*a*a));
    }

    public void ÇevreHesapla()
    {
        System.Console.Write("Karenin Tek kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Karenin Alanı : {0}",4*a);
    }
}