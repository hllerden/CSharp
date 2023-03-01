using System.Net;
using System.Net.Sockets;

namespace Project_12_AtmApplication;

public class AtmAction
{   public string mark = new string('-',25);
    public static int id = 0;
    public static string file = "Transaction Log\n\nLog ID - Log User ID - Title - IP - Date\n";
       public List<Person> persons = new List<Person>();

    public AtmAction()
    {
       persons.Add(new Person("1234","2204","2222",5000));
       persons.Add(new Person("1111","2205","2222",5000));

    }
    public void wellcome_screen()
    {   
        System.Console.WriteLine("{0}\nThis is an Atm Applicaion For My Exercise On C#\n{1}",mark,mark);
        System.Console.WriteLine("Wellcome To Harca Bank!\n{0}",mark);
        Signin signin = new Signin();
        string getUserId = signin.signin(); // Giriş ekranına yönlendirir
        menu:
        System.Console.Write("[1] - Withdraw\n[2] - Deposit\n[3] - Transfer\n[4] - End of Day\n--> Choose : "); int sec=int.Parse(Console.ReadLine());
        switch (sec)
        {   
            case 1:
                {
                    withdraw(getUserId);
                    goto menu;
                    break;
                }
            case 2:
                {
                    deposit(getUserId);
                    goto menu;
                    break;
                }
            case 3:
                {
                    transfer(getUserId);
                    goto menu;
                    break;
                }
            case 4:
                {
                    endofday();
                    goto menu;
                    break;
                }
            
            default:
                break;
        }
        

        

    }
    public void withdraw(string UserId)
    {   
        /*var result = from s in persons
	     where s.UserId == UserId
	     select s.Balance;*/
         int index = persons.IndexOf(persons.Where(p => p.UserId == UserId).FirstOrDefault());

        System.Console.WriteLine("Aviable Balance : {0} $",persons[index].Balance);
        System.Console.Write("--> Transaction Sum : "); int wd =int.Parse(Console.ReadLine());
        persons[index].Balance -=wd;
        System.Console.WriteLine("Aviable Balance : {0} $",persons[index].Balance);
        MakeLog(Convert.ToInt32(UserId), "Succesful Withdraw");
        
    }
    public void deposit(string UserId)
    {
        int index = persons.IndexOf(persons.Where(p => p.UserId == UserId).FirstOrDefault());

        System.Console.WriteLine("Aviable Balance : {0} $",persons[index].Balance);
        System.Console.Write("--> Transaction Sum : "); int wd =int.Parse(Console.ReadLine());
        persons[index].Balance +=wd;
        System.Console.WriteLine("Aviable Balance : {0} $",persons[index].Balance);

    }

    public void transfer(string UserId)
    {

    }
    public void endofday()
    {
        string filePath = @"C:\Users\by_ha\OneDrive\Projects\Kodlama calismalari\CSharp\Project-12-AtmApplication\" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
        File.WriteAllText(filePath, file);
    }
    static public void MakeLog(int userid, string title)
        {
            GetLocalIP ip = new GetLocalIP();
            
            file += String.Format("{0} - {1} - {2} - {3} - {4}\n",id, userid, title, ip.GetLocalIPAddress(), DateTime.Now);
            id++;
        }

    public class GetLocalIP
    {
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }

}