using System;
namespace _02_11_2019_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
        string input;int no,choice;
    do{
        Console.WriteLine("_02_11_2019_Assignment2 part-I");
        Console.WriteLine("Enter the Question no you want to run or for all at once enter 0");
        input=Console.ReadLine();    
        if(Int32.TryParse(input,out no))
        {
        switch(no)
        {
            case 0:
            Q1.Run();
            Q2.Run();
            Q3.Run();
            Q4.Run();
            Q5.Run();
            Q6.Run();
            Q7.Run();
            Q8.Run();
            Q9.Run();
            Q10.Run();
            Q11.Run();
            Q12.Run();
            Q13.Run();
            Q14.Run();
            Q15.Run();
            Q16.Run();
            Q17.Run();
            Q18.Run();
            break;
            case 1:
            Q1.Run();
            break;
        case 2:
            Q2.Run();
            break;
        case 3:
            Q3.Run();
            break;
        case 4:
            Q4.Run();
            break;
        case 5:
            Q5.Run();
            break;
        case 6:
            Q6.Run();
            break;
        case 7:
            Q7.Run();
            break;
        case 8:
            Q8.Run();
            break;
        case 9:
            Q9.Run();
            break;
        case 10:
            Q10.Run();
            break;
        case 11:
            Q11.Run();
            break;
        case 12:
            Q12.Run();
            break;
        case 13:
            Q13.Run();
            break;
        case 14:
            Q14.Run();
            break;
        case 15:
            Q15.Run();
            break;
        case 16:
            Q16.Run();
            break;
        case 17:
            Q17.Run();
            break;
        case 18:
            Q18.Run();
            break;
        default:
            Console.WriteLine("Question no {0} does not exist",no);
        break;
        }
       }
           else
        {
            Console.WriteLine("Not an Integer Value");
        }
       Console.WriteLine("Do you want to run another program 1.yes 2.no");
        string input2=Console.ReadLine(); 
       while(!(Int32.TryParse(input2,out choice)))
       {
        Console.WriteLine("Renter the choice");   
         input2=Console.ReadLine();                
       }
      }while(choice==1);
    }
  }
}
