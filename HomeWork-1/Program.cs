namespace HomeWork_1;
using System;

class Program
{
    static void Main(string[] args)
    {   Console.Clear();
        Console.WriteLine(" 1. Kullanici 'n' adet sayi girer.Çift olanlar ekrana yazdirilir.");
        Console.WriteLine(" 2. Kullanici 'n,m' olarak iki sayi girer.Daha sonra n adet sayi girilir.");
        Console.WriteLine("    n sayisi m e bölünebilir yada m'in kati ise konsola yazdirilir.");
        Console.WriteLine(" 3. Kullanıcı 'n' sayisini girer.Sonra n adet harf girer.Sondan başa yazdırır.");
        Console.WriteLine(" 4. Kullanici bir cümle yazar.Cümlenin toplam kelime ve harf sayisi consola yazdirilir.");
        Console.Write("\n Lütfen yapmak istediğiniz işlemin numarasini giriniz : ");
        int secim =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Seçiminiz : "+secim);

        switch (secim)
        {
            case 1:
            {
                Console.Write("\n * Lütfen kaç adet sayi girileceğiniz belirtiniz : ");
                int n =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t Girilen n sayisi : {0}",n);
                int[] dizi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\t Lütfen {0}.Sayiyi giriniz : ",i+1);
                    dizi[i]=Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\n\t Girdiğiniz Sayilardan Çift Olanlar :\n ");
                for (int i = 0; i < n; i++)
                {   if(dizi[i]%2==0)
                        Console.WriteLine("\t\t Girdiğiniz ' {0} ' sayisi çifttir.",dizi[i]);
                }
             break;   
            }
            

            case 2 :
            {                
                Console.WriteLine("\t Lütfen (n,m) sayilarini giriniz.");
                Console.Write("\t Lütfen ' n ' sayisini giriniz : ");
                int ne = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t Lütfen ' m ' sayisini giriniz : ");
                int m = Convert.ToInt32(Console.ReadLine());
                
                int[] dizin = new int[ne];
                for (int i = 0; i < ne; i++)
                {   // Console Ekarina Yazilan Sayiyi Kalın YApmak için
                    // \x1b[1mTEST\x1b[0m TEST yazan yere istediğini yaz.
                    Console.Write("\t Lütfen \x1b[1mn\x1b[0m dizisinin {0}.Sayiyi giriniz : ",i+1);
                    dizin[i]=Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < ne; i++)
                {
                    if (dizin[i]==m)
                        Console.WriteLine("\t\t n: {0} sayisi m: {1} sayisina \x1b[1meşittir\x1b[0m.",dizin[i],m);
                    else if(dizin[i]%m==0)
                        Console.WriteLine("\t\t n: {0} sayisi m: {1} sayisinin  \x1b[1mkatlarindan biridir\x1b[0m.",dizin[i],m);
                }
            break;
            }
                
            case 3:
            {
                Console.Write("\t Lütfen bir dizi giriniz: ");
                string arr=Console.ReadLine();
                char[] ar = arr.ToCharArray();
                Array.Reverse(ar);
                Console.WriteLine("\t Girdiğiniz dizinin ters çevrilmiş hali : \x1b[1m"+new string(ar) +"\x1b[0m");
            break;
            }

            case 4:
            {
                Console.Write("\t Lütfen Bir yada birden fazla cümle yaziniz: ");
                string cümle = Console.ReadLine();
                string[] kelimeler= cümle.Split(" ");
                Console.WriteLine("\t\t Girdiğiniz cümledeki kelime sayisi : {0}",kelimeler.Count());
                Console.WriteLine("\t\t Girdiğiniz cümledeki harf sayisi : {0}",cümle.Length);
                break;
            }


            default:{
                Console.WriteLine("  **  **  Öyle bir seçim yok daha yazmadık abi!!  **  **  ");
                break;
            }
        }
    }
}
