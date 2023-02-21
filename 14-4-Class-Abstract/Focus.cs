namespace _14_4_Class_Abstract;

public class Focus : IOtomobil
{
    public Marka HangiMarkaninAraci()
    {
        return Marka.Ford;
    }

    public int kacTekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}