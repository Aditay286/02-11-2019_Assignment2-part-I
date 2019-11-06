  using System;
namespace _02_11_2019_Assignment2
{
  class Q4
  {
      public static void Run()
      {
        string input;int digit=0,no,duplicate,sum=0;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
      {
        duplicate=no;
          while(no>0)
          {
            digit=no%10;
            sum+=digit;
            no/=10;           
          }
         Console.WriteLine("Sum of all the digits of no {0}  is {1}",duplicate,sum);
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }


      }
  }
}
