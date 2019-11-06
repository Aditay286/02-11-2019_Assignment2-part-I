using System;
namespace _02_11_2019_Assignment2
{
   class Q11
   {
      public static void Run()
     {
       string input;int no,even_Digit=0,flag=0;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {
         Console.Write("Last  even digit of given no {0} is ",no);
         while(no>0)
         {
             even_Digit=no%10;
            if(even_Digit%2==0)
            {
             flag=1;   
         Console.WriteLine("{0}",even_Digit);
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