namespace Project_4_DrawaCircle;

public class Circle 
{
    public void Draw_A_Circle(int r)
    {
        int coco =0;
        //int R=2*r;

        for (int j = 0; j <= (r*2)+1; j++)
        {    System.Console.Write("\n");
            for(int i=0;i<=(r*2)+1;i++)
            {  
                if(j<=r-1)
                   { if (i==(r-coco))
                        if (j==0)
                            System.Console.Write("*");
                        else
                            System.Console.Write("*");
                    else if (i==(r+1+coco))
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");}
                else
                    { 
                    if (i==(r+1+coco))
                        
                        System.Console.Write("*");
                        
                    else if (i==(r+1-coco))
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");}

                
            }
            if(j <=r)
                coco++;
            else
                coco--;
        }
       

    }
}
