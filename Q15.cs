using System;
namespace _02_11_2019_Assignment2
{
   class Q15
   {
      public static void Run()
     {
       string input;int no,digit=0,count=0;
       Console.WriteLine("Enter the no");
       input=Console.ReadLine();
       if(Int32.TryParse(input,out no))
       {

         Console.Write("The second last even digit of given no {0} is ",no);
            while(no>0)
            {
                digit=no%10;
            if(digit%2==0)
            {
                count++;
                if(count==2)
                {
                Console.WriteLine("{0}",digit);
                break;
                }
            }
                no/=10;
            }
           if(count!=2)
       Console.WriteLine("not any"); 
       }
           else
        {
            Console.WriteLine("Not an Integer value");
        }
     }
   }
}