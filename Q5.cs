 using System;
namespace _02_11_2019_Assignment2
{
  class Q5
  {
        public static void Run()
      {
        string input;int duplicate,digit=0,no,product=1,sum=0;
         Console.WriteLine("Enter the no");
        input=Console.ReadLine();
        if(Int32.TryParse(input,out no))
       {
          product=no%10;
          no/=10;
            duplicate=no; 
          while(no>0)
          {            
            digit=no%10;
            product*=digit;
            no/=10;
            sum+=product;
            product=digit;
          }
         Console.WriteLine("product of consecutive  digits of no {0}  is {1}",duplicate,sum);
        }
        else
        {
            Console.WriteLine("Not an Integer value");
        }

      }
  }
}
