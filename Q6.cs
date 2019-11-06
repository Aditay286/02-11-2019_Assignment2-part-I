using System;

namespace _02_11_2019_Assignment2
{
  class  Q6
  {
    public static void Run()
    {
       string input,input2;int no1,no2,digit1,digit2,product=1,sum=0;
       Console.WriteLine("Enter the first no");
       input=Console.ReadLine();
       Console.WriteLine("Enter the second no");
       input2=Console.ReadLine();

       if(Int32.TryParse(input,out no1)&&Int32.TryParse(input2,out no2))
       {
           Console.Write("product of each digit of two nos {0} and {1} is ",no1,no2);
           while(no1>0)
           {
             digit1=no1%10;
             digit2=no2%10;
             product=digit1*digit2;
             sum+=product;
             no1/=10;
             no2/=10;
           }
           Console.WriteLine("{0}",sum);
       }   
    }






  }









}