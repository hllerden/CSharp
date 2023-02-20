namespace _14_1__Polymorphism;
public class Canlilar
{
    protected void Beslenme()
    {
        System.Console.WriteLine("Canlilar beslenir.");
    }

    protected void Solunum()
    {
        System.Console.WriteLine("Canlilar Solunum yapar.");
    }
    protected void Bosaltim()
    {
        System.Console.WriteLine("Canlilar bosaltim yapar.");
    }

    public virtual void UyaranalaraTepki()
    {
        System.Console.WriteLine("Canlılar Uyaranlara Tepki verir.");
    }
}
