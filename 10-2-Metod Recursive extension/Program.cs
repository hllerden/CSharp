namespace _10_2_Metod_Recursive_extension;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        // Rekürsif - Öz yinelemeli Fonksiyon
        // üs alma işleri faktöryeller
        // 3^4 = 3*3*3*3

        int result=1;
        for (int i = 1; i < 5; i++)
        {
            result = result*3;
        }
        Console.WriteLine(result);
        islemler instance=new();
        Console.WriteLine(instance.Expo(3,12));

        //Ectension Metotlar
        string ifade = "ali veli Rümeli";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(ifade.CheckSpaces());
        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.LowerUpperCase());

        int[] dizi = {9,3,2,5,4,1,2,2,1,8,7,11};
        dizi.SortArray();
        dizi.EkranaYazdir();
        
        int sayi =5;
        Console.WriteLine(sayi.IsEverNumber());
        Console.WriteLine(ifade.GetFirstCharacter());
    }
}

public class islemler
{
    public int Expo(int sayi,int üs)
    {
        if(üs<2)
        {
            return sayi;
        }
        return Expo(sayi,üs-1)*sayi;
    }
    
}

public static class Extension{

    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {   
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
     public static string LowerUpperCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] Param)
    {
        foreach (int item in Param)
        {
          Console.WriteLine(item);  
        }
    }
    public static bool IsEverNumber( this int param)
    {
        return param%2 ==0;
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }

}