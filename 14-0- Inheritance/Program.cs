namespace _14_0__Inheritance;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
       /* tohumluBitki.Beslenme();
        tohumluBitki.Solunum();
        tohumluBitki.Bosaltim();
        //tohumluBitki.FotosentezYapmak();*/
        tohumluBitki.TohumlaCogalma();

        System.Console.WriteLine("*********************************");

        Kuslar marti = new Kuslar();
       /* marti.Solunum();
        marti.Beslenme();
        marti.Bosaltim();*/
        // marti.Adaptasyon();
        marti.Ucmak();
    }
}
