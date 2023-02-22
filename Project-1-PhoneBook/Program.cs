namespace Project_1_PhoneBook;
class Program
{
    static void Main(string[] args)
    {
        Phonebook phonebookaction = new Phonebook();
        bool flag = true;
        while(flag )
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine(" Telefon Rehberine Hoşgelidiniz\n\n\n" +
                " 1- Telefon numarası kaydet\n" +
                " 2- Telefon numarası sil\n" +
                " 3- Telefon numarası güncelle\n" +
                " 4- A-Z Sıralı şekilde kayıtlı numaraları göster\n" +
                " 5- Z-A Sıralı şekilde kayıtlı numaraları göster\n" +
                " 6- Rehberde arama\n" +
                " 0- Çıkış");

            int secim =Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {   
                case 1:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.add();

                    break;
                }

                case 2:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.delete();

                    break;
                }
                case 3:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.UpdateNumber();

                    break;
                }
                case 4:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.SortA_Z();

                    break;
                }
                case 5:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.SortZ_A();

                    break;
                }

                case 6:
                {   
                    Console.WriteLine("****************************************");
                    phonebookaction.search();

                    break;
                }
                case 0:
                    {flag =false ; break;}
                default:
                    break;
            }

        }    
    }
}
