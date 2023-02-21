namespace _14_3__Arayüzler_Ornek;


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