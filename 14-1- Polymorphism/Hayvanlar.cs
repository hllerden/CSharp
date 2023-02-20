namespace _14_1__Polymorphism;
public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        System.Console.WriteLine("Hayvanlar adaptasyon kurabilir");
    }

    public override void UyaranalaraTepki()
    {
        base.UyaranalaraTepki();
        System.Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

public class Sürüngenler:Hayvanlar{
    public Sürüngenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranalaraTepki();
    }

    public void SurunerekHareketEtmek()
    {
        System.Console.WriteLine("Sürüngeler sürünerek hareket ederler.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranalaraTepki();
    }
    public void Ucmak()
    {
        System.Console.WriteLine("Kuşlar uçar");
    }
}