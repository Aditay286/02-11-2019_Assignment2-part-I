using System;
namespace _02_11_2019_Assignment2
{
   class Q17
   {
      public static void Run()
   {
       string input;int no,sum=0,digit=0,consecutive_Digit;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {

         Console.Write("The sum of consecutive digits of given no {0} is ",no);
             digit=no%10;
             consecutive_Digit=digit;
             no/=10;
         while(no>0)
         {
              digit=no%10;
             consecutive_Digit+=(digit*10);          
             sum+=consecutive_Digit;
             consecutive_Digit=digit;
             no/=10;
         }
         Console.WriteLine("{0}",sum); 
       }
           else
        {
            Console.WriteLine("Not an Integer value");
        }
      }
   }
}