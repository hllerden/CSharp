namespace _7_swich_case;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Case için seçim yapiniz:  ");
        //byte a =Console.ReadLine(Convert.ToByte);
        int month =DateTime.Now.Month;


        switch (month)
        {
            case 2:
            Console.WriteLine("Şubat ayindasiniz");
            break;

            default:
            break;


        }
        //Console.WriteLine("Hello, World!");
    }
}
