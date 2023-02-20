using System;
namespace _14_2__Arayüzler;

public class DatabaseLogger : ILogger
{
    public void WriteLog()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Databese'e Log Yazar");
    }
}