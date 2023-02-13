namespace operatorler;
class Program
{
    static void Main(string[] args)
    {
        int x=3;
        int y=3;
        y =y+2;
        Console.WriteLine("Y'nin değeri:  "+y);
        y+=2; // işlemli atama
        Console.WriteLine("Y'nin değeri:  "+y);
        y/=7;

        Console.WriteLine("Y'nin değeri:  "+y);

        // Mantıksal operatörler
        // ||  && !

        bool isSuccess= true;
        bool isComplated = false;

        if(isSuccess || isComplated)
        {
            Console.WriteLine("True");
        }
        else if (isSuccess && isComplated)
        {
            Console.WriteLine("True");
        }

        //ilişkisel operatörler
        // <, > , <=, >=, == , !=

        int a=3;
        int b=4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc=a>b;
        Console.WriteLine(sonuc);
        sonuc=a<=b;
        Console.WriteLine(sonuc);
        sonuc=a>=b;
        Console.WriteLine(sonuc);
        sonuc=a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);

        // Aritmetik ifadeler
        // + - * /
    }
}
