namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        int deger;
        deger =0;
        Console.WriteLine("Hello, World!   deger:"+deger);

        byte b=5; // 1 byte yer kaplar 0-255
        sbyte c =5; // 1 byte yer kapla -127 - 127 arası
        short s =5; // 2byte yer kaplar -32768 - +32768 tam sayı
        ushort us=5; //2byte 2^16

        Int16 i16= 2;     //2byte
        int i=2;          // 4byte
        Int32 i32=2;      // 4byte yer kaplar
        Int64 i64 =2;    //8byte yer kaplar
        
        uint ui=2;      //4byte
        long l =4;      //8byte
        ulong ul=4;     //8byte

        // Real sayılar
        float f =8;     //4 byte    -
        double d =5;    //8byte
        decimal de =5;  //16 byte
        
        char ch = '2' ;  //2byte
        string stad = "Halil"  ;   //sınırsızdır

        bool bl = true;
        Boolean b2 =false;

        DateTime dt =DateTime.Now;
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.5;

        //Stringler
        
        string str1=string.Empty;
        str1="Halil ERDEN";
        string ad="Halil";
        string soyad="ERDEN";
        string Tamisim=ad +" "+soyad;
        
        //İnteger tanımlama şekilleri

        int inte1 = 5;
        int inte2 = 3;
        int inte3 = inte1 * inte2;

        //booleen

        bool bo1 =10<2;

        //değişken dönümüşleri

        string stro ="20";
        int int20 = 20;
        
        string yenideger = stro + int20.ToString();
        Console.WriteLine(yenideger);

        int int21= int20+Convert.ToInt32(stro);
        Console.WriteLine(int21);

        int int22 = int20 + int.Parse(stro);

        Console.WriteLine(int22);

        //datetime
        string datetime=DateTime.Now.ToString("dd.mm.yyyy");
        Console.WriteLine(datetime);




        }
}
