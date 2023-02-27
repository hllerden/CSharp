namespace Project_11_VotingApp;
class Program
{
    static void Main(string[] args)
    {   
        Voting voting = new Voting();
        voting.Wellcome();
        
    }
}

public class Voting
{   List<Person> persons = new List<Person>();
    List<Voting_list> voting_lists = new List<Voting_list>();
    public Voting()
    {
        persons.Add(new Person("Halil","123"));
        voting_lists.Add(new Voting_list("Spor",1));
        voting_lists.Add(new Voting_list("Müzik",1));
        voting_lists.Add(new Voting_list("Film",1));
        voting_lists.Add(new Voting_list("XXX",1));


    }
    public void Wellcome()
    {
        Console.WriteLine("**********************************");
        Console.WriteLine("Wellcome To  Voting Application !!\n");
        Console.WriteLine(" 1 - Mevcut Oylama Durumunu Gör . ");
        Console.WriteLine(" 2 - Oy Kullan");
        Console.WriteLine(" 3 - Üyelik işlemleri\n");
        Console.Write(" Yapmak istediğiniz işlemi seçiniz : ");
        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {   
            case 1:
                {   //Voting voting = new Voting();
                    //voting.VotingStatus();
                    VotingStatus();
                    break;
                }
            case 2:
            {
                Vote();
                break;
            }
            case 3:
            {
                Membership_create();
                break;
            }
            default:
                break;
        }
    }

    public void VotingStatus()
    {
        System.Console.WriteLine("\n Şu anda mevcut Kategori sayısı : {0}",voting_lists.Count);
        System.Console.WriteLine(" Kullanılan Oy sayısı : {0}",Voting_list.Oran);
        int i =1;
        foreach (var item in voting_lists)
        {   
            System.Console.WriteLine("{0} - {1} Kategorisi , Oy Oranı : %{2}",i,item.Name,((item.Rate)*100)/Voting_list.Oran);
            i++;
        }

    }

    public void Vote()
    {   LogginScreen:
         System.Console.WriteLine("Oy Kullanmadan önce Giriş Yapmalısınız !!");
        System.Console.WriteLine(" Giriş Yapmak için     (1)\n"
                                +" Hesap Oluşturmak için (2)"); int secim = int.Parse(Console.ReadLine());
        if(secim==1)
        {
            System.Console.Write(" Username : "); string Username = Console.ReadLine().ToLower();
            int flag = 0;
            foreach (var item in persons)
            {
                if (Username ==item.Username.ToLower())
                {
                    System.Console.Write(" Password : "); string Password = Console.ReadLine().ToLower();
                    if (Password ==item.Password.ToLower())
                    {
                       
                        VotingStatus();
                        System.Console.WriteLine("Başarıyla Giriş Yaptınız !!");
                        System.Console.Write(" Oy kullanmak istediğiniz kategoriyi seçiniz : "); int oyindex =int.Parse( Console.ReadLine());

                        voting_lists[oyindex-1].Rate +=1;
                        Voting_list.Oran+=1;
                        System.Console.WriteLine("{0} Kategorisine Oy Kullandınız.",voting_lists[oyindex-1].Name);
                        
                    }
            
                }
                else if(flag==persons.Count()-1)
                {
                    System.Console.WriteLine("Username Hatali !!\n"
                                            +"Yeniden dene     (1)\n"
                                            +"Üyelik oluştur   (2)");  secim = int.Parse(Console.ReadLine());
                    if (secim==1)
                        goto LogginScreen;
                    else   
                        {   
                            Membership_create();
                            goto LogginScreen;
                        }
                        
                    
                }
                flag++;
            }

        }
        else { Membership_create();goto LogginScreen;}
            
        

       

    }

    public void Membership_create()
    {
        System.Console.WriteLine("Üyelik Oluşturduğunuz için mutluyuz!!");
        System.Console.Write(" Username : "); string username = Console.ReadLine().ToLower();
        System.Console.Write(" Password : "); string password = Console.ReadLine().ToLower();
        persons.Add(new Person(username,password));
        
    
    

}
