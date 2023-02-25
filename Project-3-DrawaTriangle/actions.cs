namespace Project_3_DrawaTriangle;

public class actions
{
    public void DrawTriangle(int a)
    {   System.Console.WriteLine("Çizilen Eşkenar Üçgen : ");
        for (int i = 0; i < a; i++)
        {   System.Console.Write("\n");
            for (int j=i; j < a; j++)
            {
                System.Console.Write("*");
            }
            
            
        }

    }
}