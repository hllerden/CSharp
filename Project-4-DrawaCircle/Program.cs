namespace Project_4_DrawaCircle;
class Program
{
    static void Main(string[] args)
    {   Circle circle=new Circle();

        System.Console.WriteLine("***************************************");
        System.Console.WriteLine("Bu Projede Kullanıcı bir Dairenin yarıçap zunlukğunu giricek\n"
                                +"Girilen değerlerle bir daire oluşturulup console ekranına yazdırılacak\n"
                                +"Girilen bütün değerler tamsayi olmalidir. Değilse en yakın tam sayi değere yuvarlanır.");
        System.Console.Write("\n\n Dairenin yari çapı 'r' uzunluğu : ");
        int r = int.Parse(Console.ReadLine());
        circle.Draw_A_Circle(r);
        
    }
}
