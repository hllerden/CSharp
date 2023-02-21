namespace _14_3__Arayüzler_Ornek;

public class Civic : IOtomobil
{
    public Marka HangiMarkaninAraci()
    {
        return Marka.Honda;
    }

    public int kacTekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Mavi;
    }
}
