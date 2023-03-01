namespace Project_12_AtmApplication;

public class Person
{
    private string userId; public string UserId { get => userId; set => userId = value; }

    private string cardNo; public string CardNo { get => cardNo; set => cardNo = value; }
    
    private string password; public string Password { get => password; set => password = value; }
    private int balance; public int Balance { get => balance; set => balance = value; }

    public Person(){}
    public Person(string userId, string cardNo, string password, int balance)
    {
        this.UserId = userId;
        this.CardNo = cardNo;
        this.Password = password;
        this.Balance = balance;
    }


}