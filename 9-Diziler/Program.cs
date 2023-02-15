namespace _9_Diziler;
class Program
{
    static void Main(string[] args)
    {
        //Dizi tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

        int[] dizi;
        dizi =new int[5];

        //dizilere değer atama ve erişim

        renkler[0]="Mavi";
        Console.WriteLine(hayvanlar[0]);
        dizi[3]=10;

       // Console.WriteLine(item in dizi);

        //Döngülerle dizi kullanımı
        //

        Console.WriteLine("Lütfen dizinin eleman sayisini giriniz: ");
        int diziUzun=int.Parse(Console.ReadLine());
        int[] sayiDizi= new int[diziUzun];
        
        for (int i = 0; i < diziUzun; i++)
        {
            Console.Write("{0}. elemanı giriniz : ",i+1);
            sayiDizi[i]=int.Parse(Console.ReadLine());

        }
        int toplam =0;
        foreach (var sayi in sayiDizi)
        {
            toplam+=sayi;
        }
        Console.WriteLine("Ortalama :" + toplam/diziUzun);


    }

}
