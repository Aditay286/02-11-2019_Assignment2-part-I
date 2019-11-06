 using System;
namespace _02_11_2019_Assignment2
{
  class Q9
  {
        public static void Run()
      {
        string input;int digit=0,no,count=0;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
       {
           Console.Write("no of digits in a given number {0} is ",no);
          while(no>0)
          {            
            digit=no%10;
            no/=10;
            ++count;
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
