namespace _14_4_Class_Abstract;
class Program
{
    static void Main(string[] args)
    {
        Focus focus = new Focus();
        System.Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(focus.StandartRengiNe().ToString());

        Corolla corolla = new Corolla();
        System.Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(corolla.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(corolla.StandartRengiNe().ToString());

        Civic civic = new Civic();
        System.Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(civic.StandartRengiNe().ToString());

        System.Console.WriteLine("********************************************************");

        NewFocus newfocus = new NewFocus();
        System.Console.WriteLine(newfocus.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(newfocus.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(newfocus.StandartRengiNe().ToString());

        NewCorolla newcorolla = new NewCorolla();
        System.Console.WriteLine(newcorolla.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(newcorolla.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(newcorolla.StandartRengiNe().ToString());

        NewCivic newcivic = new NewCivic();
        System.Console.WriteLine(newcivic.HangiMarkaninAraci().ToString());
        System.Console.WriteLine(newcivic.kacTekerlektenOlusur().ToString());
        System.Console.WriteLine(newcivic.StandartRengiNe().ToString());

    }
}