namespace Project_3_DrawaTriangle;
class Program
{
    static void Main(string[] args)
    {
        actions action = new actions();
        System.Console.WriteLine("***************************************");
        System.Console.WriteLine("Bu Projede Kullanıcı bir *eşitkenar* üçgenin kenar uzunlukğunu giricek\n"
                                +"Girilen değerlerle bir ücgen oluşturulup console ekranına yazdırılacak\n"
                                +"Girilen bütün değerler tamsayi olmalidir. Değilse en yakın tam sayi değere yuvarlanır.");
        System.Console.Write("\n\n Eşkenar Üçgenin 'a' kenar uzunluğu : ");
        int TriA = int.Parse(Console.ReadLine());

        action.DrawTriangle(TriA);


    }
}
