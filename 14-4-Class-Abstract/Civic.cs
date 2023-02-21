namespace _14_4_Class_Abstract;
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
