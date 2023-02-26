namespace Project_10_String_check;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bu programda girilen bir string de kelimelere ayırır.\n"
                        +" iki sessiz harf yan yana ise True değilse False verir.");

        System.Console.Write("Input Cümle : ");
        string input = Console.ReadLine();
        Metot metot = new Metot();
        metot.SessizHarfCheck(input);

    }
}

class Metot
{
    public void SessizHarfCheck(string str)
    {
        string[] kelimeler = str.Split().ToArray();
        char[] vocals = "aeiouAEIOU".ToCharArray();
        bool durum = false;
        for (int i = 0; i < kelimeler.Count(); i++)
        {
            char[] harfler = kelimeler[i].ToCharArray();
            
            for (int j = 0; j < harfler.Count()-1; j++)
            {
                if (vocals.Any(harfler[j].Equals)==false)
                    if(vocals.Any(harfler[j+1].Equals)==false)
                        {System.Console.Write("True ");
                            break;}
                else if (j==harfler.Count()-2)
                    System.Console.WriteLine("False ");
            }   
            
        }


    }
}
