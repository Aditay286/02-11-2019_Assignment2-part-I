using System;
namespace _02_11_2019_Assignment2
{
  class Q2
  {
      public static void Run()
      {
         int ans,input;
         Console.WriteLine("Enter the no");
        input=Console.Read();
        if(input>=48&&input<=57)
        {
           ans=input-48;
         Console.WriteLine("For k=1 value is {0}",ans);
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }
      }
  }

    
}