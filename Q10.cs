using System;
namespace _02_11_2019_Assignment2
{
   class Q10
   {
      public static void Run()
     {
       string input;int no,count=0;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {
         Console.Write("No of even digits of given no {0} is ",no);
         while(no>0)
         {
            if((no%10)%2==0)
            {
                count++;
            }
            no/=10;
         }
         Console.WriteLine("{0}",count);
       }
           else
        {
            Console.WriteLine("Not an Integer value");
        }

      }
   }
}