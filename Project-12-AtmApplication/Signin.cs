namespace Project_12_AtmApplication;

public class Signin : AtmAction
{   
    public string signin()
    {   logginscreen:
        System.Console.Write("User id  : "); string getUserId = Console.ReadLine();
       // System.Console.Write("Password ="); string getPassword = Console.ReadLine();
        int flag =0;
        foreach (var item in persons)
            {
                if (getUserId ==item.UserId.ToLower())
                {
                    System.Console.Write("Password : "); string getPassword = Console.ReadLine().ToLower();
                    if (getPassword ==item.Password.ToLower())
                    {
                       System.Console.WriteLine("Sign İn Success!!\n{0}",mark);
                    }
                    else
                    {
                    System.Console.WriteLine("Password Id Not Match!! Try Again !!\n{0}",mark);
                    goto logginscreen;
                    }
                }    
            
                
                else if(flag==persons.Count())
                {
                    System.Console.WriteLine("User Id Not Match!! Try Again !!\n{0}",mark);
                    goto logginscreen;
                }
                flag++;
            }
        return getUserId;
    }
}