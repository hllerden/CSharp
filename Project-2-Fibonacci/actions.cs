namespace Project_2_Fibonacci;

public class actions
{   
    public void CreateFibonacci(int derinlik)
    {
        int[] fibo = new int[derinlik];
        fibo[0]=0;
        fibo[1]=1;
        for (int i = 2; i < derinlik; i++)
        {   
            fibo[i]=fibo[i-1]+fibo[i-2];   
        }
         int ortalama = fibo.Sum()/fibo.Length;

        Console.WriteLine("[{0}]", string.Join(", ", fibo)); 
        System.Console.WriteLine("Fibonachi dizinin ortalama ağırlığı : {0}",ortalama);  
     //return System.Console.WriteLine(5);
    }

    public void CreateFibonacci(int derinlik,int ilk,int ikinci)
    {
        int[] fibo = new int[derinlik];
        fibo[0]=ilk;
        fibo[1]=ikinci;
        for (int i = 2; i < derinlik; i++)
        {   
            fibo[i]=fibo[i-1]+fibo[i-2];   
        }
         int ortalama = fibo.Sum()/fibo.Length;

        Console.WriteLine("[{0}]", string.Join(", ", fibo)); 
        System.Console.WriteLine("Fibonachi dizinin ortalama ağırlığı : {0}",ortalama);  
     //return System.Console.WriteLine(5);
    }

}