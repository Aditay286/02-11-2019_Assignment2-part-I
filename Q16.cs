using System;
namespace _02_11_2019_Assignment2
{
   class Q16
   {
      public static void Run()
     {
       string input;int no,digit=0,last_Digits=0,new_No=0,position=1;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {
         Console.Write("The required output for given input {0} is ",no);
         while(no>0)
         {
             digit=no%10;
             if(digit%2!=0)
             {
                  new_No=(no*position)+(last_Digits/2);              
                 Console.WriteLine("{0}",new_No*3);
                 break;
             }
                   last_Digits+=(digit*position);
            no/=10;
            position*=10;
         }
       }
           else
        {
            Console.WriteLine("Not an Integer value");
        }

      }
   }
}