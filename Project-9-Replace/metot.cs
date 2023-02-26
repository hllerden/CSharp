using System.Text;

namespace Project_9_Replace;

public class metot
{   

    public void Reverse_string(string str)
    {
        string[] arr =str.Split().ToArray();
        char temp =' ';
        string[] Comp ={};
        for (int i = 0; i < arr.Count(); i++)
        {   StringBuilder sb = new (arr[i]);
            temp=sb[0]; 
            sb[0]=sb[sb.Length-1];
            sb[sb.Length-1] = temp;
            System.Console.Write("{0} ",sb.ToString());
            //string tem = sb.ToString();
            //Comp[i+1] = tem.Split();
        }
        
     /*   foreach (var item in arr)
        {
            temp=item[0];
            StringBuilder sb = new (item); 
            sb[0]=sb[sb.Length-1];
            sb[sb.Length-1] = temp;
            comp[0]=sb.ToString();
            i+=1;

        }*/
    }
}

