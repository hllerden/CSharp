namespace Project_9_Replace;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Revere işlemi yapıcaz");
        System.Console.Write("input : ");
        string giris = Console.ReadLine();
        metot aksiyon =new metot();

        aksiyon.Reverse_string(giris);       
         //Reverse_String(giris);

    }
    
}

