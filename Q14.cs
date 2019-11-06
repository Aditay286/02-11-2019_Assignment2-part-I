using System;
namespace _02_11_2019_Assignment2
{
   class Q14
   {
      public static void Run()
    {
       string input;int no,digit=0,flag=0;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {
         Console.Write("Last Digit which is multiple of 3 of given no {0} is ",no);
         while(no>0)
         {
             digit=no%10;
            if(digit%3==0)
            {
             flag=1;   
         Console.WriteLine("{0}",digit);
         break;
            }
            no/=10;
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