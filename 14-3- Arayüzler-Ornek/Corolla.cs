namespace _14_3__Arayüzler_Ornek
{
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


}