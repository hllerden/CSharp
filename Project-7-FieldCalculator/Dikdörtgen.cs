namespace Project_7_FieldCalculator;

public class Dikdörtgen
{
     public void run_dikdörtgen()
    {
        System.Console.WriteLine(" 1 - Alan Hesapla \n"
                                +" 2 - Hacim Hesapla\n"
                                +" 3 - Çevre Hesapla\n");
        System.Console.Write("İşlemi Seçiniz : ");
        int secim = int.Parse(Console.ReadLine());
        Dikdörtgen dikdörtgen=new Dikdörtgen();
        switch (secim)
        {
            case 1:
                dikdörtgen.AlanHesapla();
                break;
            case 2:
                dikdörtgen.HacimHesapla();
                break;
            case 3:
                dikdörtgen.ÇevreHesapla();
                break;
            
            default:
                break;
        }

    }
    public void AlanHesapla()
    {
        System.Console.Write("Dikdörtgen 'A' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Dikdörtgen 'B' kenar Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Dikdörtgenin Alanı : {0}",a*b);
    }

    public void HacimHesapla()
    {
        System.Console.Write("Dikdörtgen 'A' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Dikdörtgen 'B' kenar Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
        System.Console.Write("Dikdörtgen 'C' kenar Uzunluğunu Giriniz : ");
        int c = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dikdörtgenin Hacmi : {0}",(a*b*c));
    }

    public void ÇevreHesapla()
    {
        System.Console.Write("Dikdörtgen 'A' kenar Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Dikdörtgen 'B' kenar Uzunluğunu Giriniz : ");
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Dikdörtgenin Alanı : {0}",2*(a+b));
    }
}