
namespace Project_1_PhoneBook;

public class Phonebook 
{

    List<Person> Persons = new List<Person>();// Listemiz bir sınıfı tutacak böylece kişiye ait sınıfımız daha kolay tutulacaktır.
        public Phonebook()
        {
            // Başlagıç olarak 5 adet numara constuructorda atanmıştır
            Persons.Add(new Person("ali", "göçer", "05482541154"));
            Persons.Add(new Person("veli", "kalir", "05984455214"));
            Persons.Add( new Person("hans", "zimmer", "05554412411"));
            Persons.Add(new Person("feridun", "düzağaç", "05123456789"));
            Persons.Add(new Person("elif", "yalkın", "05458789565"));
        }

        public void add()
        {
            System.Console.WriteLine("Lütfen eklemek istediğiniz kişinin bilgilerini giriniz:");
            System.Console.Write("Eklenecek kişinin Adı              : "); string name=Console.ReadLine();       name=name.ToLower();
            System.Console.Write("Eklenecek kişinin Soyadı           : "); string surname=Console.ReadLine();    surname=surname.ToLower();
            System.Console.Write("Eklenecek kişinin Telefon numarası : "); string no=Console.ReadLine();         no=no.ToLower();

            Persons.Add(new Person(name,surname,no));
        
        }

        public void delete()
        {   Yenidensil:
            System.Console.Write("Lütfen silmek istediğiniz kişinin Adını ya da Soyadını giriniz : ");
            string nameorsuname = Console.ReadLine();
            nameorsuname=nameorsuname.ToLower();
            
            for(int i=0;i<= Persons.Count;i++)
            {
                if ( Persons[i].Name==nameorsuname |Persons[i].SurName==nameorsuname)
                 {  
                    System.Console.Write("* {0} {1} * isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",Persons[i].Name,Persons[i].SurName);
                    char secimdelyn =Convert.ToChar(Console.ReadLine());
                    if (secimdelyn=='y')
                    {
                        System.Console.WriteLine(" Rehberden *" + Persons[i].Name +"  " +Persons[i].SurName  +"*  kişisi başarıyla silindi");
                        Persons.RemoveAt(i);
                        break;
                    }
                    else
                        break;
                    
                 }

                else if(i==Persons.Count-1)
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n"
                                            + " * Silmeyi sonlandırmak için : (1)\n"
                                            + " * Yeniden denemek için      : (2)\n"
                                            + "Yapmak istediğiniz işlem : ");
                    int secimdel = int.Parse(Console.ReadLine());
                    if (secimdel==1)
                        break;
                    else 
                         goto Yenidensil;
                        break;
                    
                }

            }
        }

        public void UpdateNumber()
        {
            Yenidenupdate:
            System.Console.Write("Numarasını güncellemek istediğiniz kişinin Adını ya da Soyadını giriniz : ");
            string nameorsuname = Console.ReadLine();
            nameorsuname=nameorsuname.ToLower();
            
            for(int i=0;i<= Persons.Count;i++)
            {
                if ( Persons[i].Name==nameorsuname |Persons[i].SurName==nameorsuname)
                 {  
                    System.Console.Write("* {0} {1} * isimli kişi rehberdeki numarasi * {2} *, değiştirmek istiyor musunuz ?(y/n)",Persons[i].Name,Persons[i].SurName,Persons[i].Number);
                    char secimdelyn =Convert.ToChar(Console.ReadLine());
                    if (secimdelyn=='y')
                    {      
                        System.Console.WriteLine("Yeni numarayi giriniz. : ");
                        Persons[i].Number=Console.ReadLine();
                        System.Console.WriteLine(" *" + Persons[i].Name +"  " +Persons[i].SurName  + "  "+Persons[i].Number+"*  kişisinin Numarasi başarıyla Güncellendi");
                        
                        break;
                    }
                    else
                        break;
                    
                 }

                else if(i==Persons.Count-1)
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n"
                                            + " * Silmeyi sonlandırmak için : (1)\n"
                                            + " * Yeniden denemek için      : (2)\n"
                                            + "Yapmak istediğiniz işlem : ");
                    int secimdel = int.Parse(Console.ReadLine());
                    if (secimdel==1)
                        break;
                    else 
                         goto Yenidenupdate;
                        break;
                    
                }

            }
        }


        public void SortA_Z()
        {   System.Console.WriteLine("\t ***** Telefon Rehberi *****");
            var sorthed = Persons.OrderBy(x=>x.Name).ThenBy(x=>x.SurName).ThenBy(x=>x.Number);

            foreach (var item in sorthed)
            {
                System.Console.WriteLine(" İsim       :  {0}",item.Name);
                System.Console.WriteLine(" Soy İsim   :  {0}",item.SurName);
                System.Console.WriteLine(" Tel. No    :  {0}\n\n\t **********\n",item.Number);
            }
        }

        public void SortZ_A()
        {   System.Console.WriteLine("\t ***** Telefon Rehberi *****");
            var sorthed = Persons.OrderBy(x=>x.Name).ThenBy(x=>x.SurName).ThenBy(x=>x.Number).Reverse();

            foreach (var item in sorthed)
            {
                System.Console.WriteLine(" İsim       :  {0}",item.Name);
                System.Console.WriteLine(" Soy İsim   :  {0}",item.SurName);
                System.Console.WriteLine(" Tel. No    :  {0}\n\n\t **********\n",item.Number);
            }
        }

        public void search()
        {   Arama:
            System.Console.Write(" İsim veya soyisime göre arama yapmak için: (1)\n"
                                 +"Telefon numarasına göre arama yapmak için: (2)\n\n");
            System.Console.Write("Lütfen arama yapma tipini seçiniz : "); int sec=int.Parse(Console.ReadLine());
            if (sec ==1)
            {
               System.Console.WriteLine("Arama yapmak istediğiniz kişinin adı yada SoyAdını giriniz"); 
               string nameorsuname = Console.ReadLine(); nameorsuname=nameorsuname.ToLower();     
              for(int i=0;i<= Persons.Count;i++)
            {
                if ( Persons[i].Name==nameorsuname |Persons[i].SurName==nameorsuname)
                 {  
                    System.Console.WriteLine(" İsim       :  {0}",Persons[i].Name);
                    System.Console.WriteLine(" Soy İsim   :  {0}",Persons[i].SurName);
                    System.Console.WriteLine(" Tel. No    :  {0}\n\n\t **********\n",Persons[i].Number);
                    break;
                    
                 }

                else if(i==Persons.Count-1)
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n"
                                            + " * Aramayı sonlandırmak için : (1)\n"
                                            + " * Yeniden denemek için      : (2)\n"
                                            + "Yapmak istediğiniz işlem : ");
                    int secimdel = int.Parse(Console.ReadLine());

                    if (secimdel==1)
                        break;
                    else 
                         goto Arama;
                        break;
                    
                }

            }
            }

            
            
            

            }
        }
    
