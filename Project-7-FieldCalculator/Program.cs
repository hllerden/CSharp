namespace Project_7_FieldCalculator;
class Program
{
    static void Main(string[] args)
    {   
        System.Console.WriteLine(" 1 - Kare \n"
                                +" 2 - Dikdörtgen\n"
                                +" 3 - Üçgen\n"
                                +" 4 - Daire");
        System.Console.Write("Geometrik Şekili Seçiniz : ");
        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {   
            case 1:
                    Kare kare = new Kare();
                    kare.run_Kare();


                break;
            case 2:
                    Dikdörtgen diktörtgen = new Dikdörtgen();
                    diktörtgen.run_dikdörtgen();
                break;
            case 3:
               Üçgen üçgen = new Üçgen();
               üçgen.run_Ücgen();
               break;

                break;
            case 4:
                Daire daire = new Daire();
                daire.Run_Daire();
                break;
            
            default:
                break;
        }
    }
}
