 using System;
namespace _02_11_2019_Assignment2
{
  class Q7
  {
        public static void Run()
      {
        string input;int digit=0,no,positions=1,product=1;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
       {
           Console.Write("Positional value of digits of no {0} is ",no);
          while(no>0)
          {            
            digit=no%10;
            product=positions*digit;
            Console.WriteLine("{0} ",product);
            no/=10;
            positions*=10;
          }
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }

      }
  }
}
