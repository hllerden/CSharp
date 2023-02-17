namespace _11_0_String_metotlari;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string degisken = ("Dersimiz Csharp, Hosgeldiniz!");
        string degisken2 = ("Dersimiz Csharp");


        // Length;
        Console.WriteLine("Değişken uzunluğu : {0}",degisken.Length);

        // ToUpper To Lower
        Console.WriteLine("Değişken Upper : "+degisken.ToUpper());
        Console.WriteLine("Değişken Lower : "+degisken.ToLower());

        //Concat
        Console.WriteLine("Değişken Concat : "+string.Concat(degisken,"Merhaba"));

        // Compare , CompareTo
        // 1. degisken 2. degiskenden daha küçükse 1 döndürür
        Console.WriteLine("Değiken Compare : "+degisken.CompareTo(degisken2)); //0,1,-1
        Console.WriteLine("Değiken Compare True : "+string.Compare(degisken,degisken2,true));
        Console.WriteLine("Değiken Compare False : "+string.Compare(degisken,degisken2,true));

        // Contains
        Console.WriteLine("Degisken 1 ve degişken 2 Contains. 1in içinde iki var mı "+degisken.Contains(degisken2));
        Console.WriteLine("Degisken 1 hoşgeldiniz ile biter mi "+degisken.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine("Degisken 1 Merhaba ile başlar mı "+degisken.StartsWith("Merhaba"));

        // Index OF
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine("Last indeks of 'i' : "+degisken.LastIndexOf("i"));
        // Insert
        Console.WriteLine("Degisken insert"+degisken.Insert(0,"Merhaba")); // 0dan başla "merhaba ekle""
        
        // PadLeft, PadRigt
        Console.WriteLine("degisken Pad left degisken 2 ye 30 ekle: "+(degisken+degisken2.PadLeft(30)));
        Console.WriteLine("degisken Pad left degisken 2 ye 30 ekle: "+(degisken+degisken2.PadLeft(30,'*')));
        Console.WriteLine("degisken Pad rigt degisken 2 ye 30 ekle: "+(degisken.PadRight(30)+degisken2));
        Console.WriteLine("degisken Pad rigt degisken 2 ye 30 ekle: "+(degisken.PadRight(30,'*')+degisken2));

        // Remove
        Console.WriteLine("Degişken remove - "+degisken.Remove(10));
        Console.WriteLine("Degişken remove - "+degisken.Remove(5,3));
        Console.WriteLine("Degişken remove - "+degisken.Remove(0,1));

        //Replace
        Console.WriteLine("Repalce : "+degisken.Replace("Csharp","C#"));
        Console.WriteLine("Repalce : "+degisken.Replace(" ","*"));
        //Split
        Console.WriteLine("Degisken split : "+degisken.Split(' ')[1]);
        //Substring 4.indeksten cümlenin sonuna git
        Console.WriteLine("Degisken substring : "+degisken.Substring(4));
         Console.WriteLine("Degisken substring : "+degisken.Substring(4,6));





   
    }   



}
