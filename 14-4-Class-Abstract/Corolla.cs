namespace _14_4_Class_Abstract;


public class Corolla : IOtomobil
{
    public Marka HangiMarkaninAraci()
    {
        return Marka.Toyota;
    }

    public int kacTekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
       return Renk.Siyah;
    }
}


