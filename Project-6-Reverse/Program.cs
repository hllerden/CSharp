namespace Project_6_Reverse;
class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Bu Projede bir stringi reverse ederek ekrana yaxdıracaktir.");
        System.Console.WriteLine("İnput : Bugün çok uykum var\n"
                                +"Output: arv mukyu koç nügub");

        System.Console.Write("İnput : ");
        string giris = Console.ReadLine();
        System.Console.WriteLine(giris.Reverse().ToArray());
       
    }
}
