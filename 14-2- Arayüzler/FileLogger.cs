using System;
namespace _14_2__Arayüzler;

public class FileLogger : ILogger
{
    public void WriteLog()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Dosyaya Log Yazar");
    }
}