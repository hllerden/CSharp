namespace _5_Try_Catch;
class Program
{
    static void Main(string[] args)
    {   
        try
        {
            Console.WriteLine("Bir Sayi giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Girmiş olduğunuz sayi1: "+sayi1);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata:  "+ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem Tamamlandı!!!!");
        }

        try
        {
            //int a=int.Parse(null);
            //int a=int.Parse("test");
            int a=int.Parse("1122215421545215");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("*** Boş Değer Girdiniz ***");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        { 
            Console.WriteLine("*** Veri tipi uygun değil ***");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        { 
            Console.WriteLine("*** Veri sinirlari disinda bir deger girdiniz ***");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İslem basari ile tamamladi.");
        }


    }
}
