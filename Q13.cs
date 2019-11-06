using System;
namespace _02_11_2019_Assignment2
{
   class Q13
   {
      public static void Run()
     {
       string input;int no,prev_Even_Digit=-1,next_Even_Digit=0,flag=0;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {
         Console.Write("Digit immediately after last even digit of given no {0} is ",no);
         while(no>0)
         {
             next_Even_Digit=no%10;
            if(next_Even_Digit%2==0)
            {
             flag=1;   
         Console.WriteLine("{0}",prev_Even_Digit);
         break;
            }
            no/=10;
            prev_Even_Digit=next_Even_Digit;
         }
         if(flag!=1)
         Console.WriteLine("not any");       
       }
           else
        {
            Console.WriteLine("Not an Integer value");
        }

      }
   }
}