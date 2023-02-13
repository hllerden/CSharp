namespace _6_if_else;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if(time>=6 && time<11)
            Console.WriteLine("Günaydın!");
        else if(time <=18)
            Console.WriteLine("iyi günler!");
        else
            Console.WriteLine("iyi Geceler!");
        
        string sonuc = time <=18 ? "İyi Günler" : "iyi Geceler!!";

        sonuc =time >=6 && time<=11 ? "Günaydin!!" : time <=18 ? "İyi Günler" : "iyi Geceler!!";
        Console.WriteLine(sonuc);
    }
}
