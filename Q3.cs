  using System;
namespace _02_11_2019_Assignment2
{
  class Q3
  {
      public static void Run()
      {
        string input;int prev_digit=0,next_digit=0,no;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
        {
            prev_digit=0;
          while(no>0)
          {
           prev_digit=next_digit;
            next_digit=no%10;
            no/=10;           
          }
         Console.WriteLine("For position=2 value is {0}",prev_digit);
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }


      }
  }
}
