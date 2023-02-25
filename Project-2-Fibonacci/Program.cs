namespace Project_2_Fibonacci;
class Program
{
    static void Main(string[] args)
    {
        actions action =new actions();
        System.Console.WriteLine("***************************************");
        System.Console.WriteLine("Bu Projede Kullanıcı Bir Derinlik değeri giricek\n"
                                +"Girilen değer deriniliğinde bir fibonacci serisi oluşturulucak\n"
                                +"fibonacci Serisindeki değerlerin ortalamasi alinir Ekrana yazdirilicaktir.");
        System.Console.Write("\n\n Fibonacci sayisinin değerlerini giriniz. (Tam sayi olali) : ");
        int derinlikref = int.Parse(Console.ReadLine());
        action.CreateFibonacci(derinlikref);
        // CreateFibonacci methodu overload edilip kullanıcının başlangıç değerlerini atamasına imkan vermiştir.
        //action.CreateFibonacci(derinlikref,1,5);
        
        
        
        
        
    }
}
