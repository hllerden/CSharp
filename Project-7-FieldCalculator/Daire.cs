namespace Project_7_FieldCalculator;

public  class Daire
{ 
     public Daire()
    {
       
    }
    public void Run_Daire()
    {
         System.Console.WriteLine(" 1 - Alan Hesapla \n"
                                +" 2 - Hacim Hesapla\n"
                                +" 3 - Çevre Hesapla\n");
        System.Console.Write("İşlemi Seçiniz : ");
        int secim = int.Parse(Console.ReadLine());
        Daire daire = new Daire();
        switch (secim)
        {
            case 1:
                daire.AlanHesapla();
                break;
            case 2:
                daire.HacimHesapla();
                break;
            case 3:
                daire.ÇevreHesapla();
                break;
            
            default:
                break;
        }

    }
    public void AlanHesapla()
    {
        System.Console.Write("Daire 'r' yarıçap Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Dairein Alanı : {0}",((a*a)*3.14));
    }

    public void HacimHesapla()
    {
        System.Console.Write("Daire 'r' yarıçap Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Kürenin Hacmi : {0}",(Math.Pow(a,3)*3.14*4)/3);
    }

    public void ÇevreHesapla()
    {
        System.Console.Write("Daire 'r' yarıçap Uzunluğunu Giriniz : ");
        int a = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dairein Alanı : {0}",2*(a*3.14));
    }
}