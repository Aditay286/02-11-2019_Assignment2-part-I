using System;

namespace _02_11_2019_Assignment2
{
  class Q1
  {
      public static void Run()
      {
         string input,input2;int no,k,flag,ans=0;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        Console.WriteLine("Enter the position of digit from last u want to extract");  
        input2=Console.ReadLine();   
        if(Int32.TryParse(input,out no)&&Int32.TryParse(input2,out k))
        {
          flag=k;
          while(flag-->0)
          {
            ans=no%10;
            no/=10;
          }
         Console.WriteLine("For position={0} from last value is {1}",k+1,ans);
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }


      }
  }

    
}