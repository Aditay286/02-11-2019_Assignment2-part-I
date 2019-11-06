 using System;
namespace _02_11_2019_Assignment2
{
  class Q8
  {
        public static void Run()
      {
        string input;int digit=0,no,sum=0;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
       {
           Console.Write("sum of even digits of given number {0} is ",no);
          while(no>0)
          {            
            digit=no%10;
            if(digit%2==0)
            {
       sum+=digit;
            }
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
