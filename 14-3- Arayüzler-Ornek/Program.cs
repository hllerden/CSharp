namespace _14_3__Arayüzler_Ornek;
class Program
{
    static void Main(string[] args)
    {
        Focus focus = new Focus();
        System.Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(focus.StandartRengiNe().ToString());

        Focus corolla = new Focus();
        System.Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(corolla.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(corolla.StandartRengiNe().ToString());

        Focus civic = new Focus();
        System.Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(civic.StandartRengiNe().ToString());


    }
}
