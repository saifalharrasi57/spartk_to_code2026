using System.Net.Security;

namespace Csharp_Fundamentals_part_2;

class Program
{
    static void Main(string[] args)
    {
        // ///task1: countdown 
        // Console.Write("Dear user , please enter a number to countdown: ");
        // try
        // {
        //     int counter = int.Parse(Console.ReadLine());
        //
        //
        //
        //     for (int i = counter; i >= 1; i -= 1)
        //     {
        //         Console.WriteLine(i);
        //     }
        //
        //     Console.WriteLine("liftoff");
        // }
        //
        // catch (FormatException ex)
        // {
        //     Console.WriteLine("you enter is not valid");
        // }
        
        
        // //task2 
        // int total = 0;
        // Console.Write("enter a positive number N: ");
        // int N = int.Parse(Console.ReadLine());
        // for (int i = 0; i <= N; i += 1)
        // {
        //     total += i;
        //    
        //
        // }
        // Console.Write($"total = {total}");
        //
        //



        // /// task3
        // Console.Write("Dear user ,enter number to see its multiplication table  : ");
        //
        //     int number = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= 10; i += 1)
        //     {
        //         int answer = number * i;
        //         Console.WriteLine($"{number} * {i}= {answer}");
        //     }
        
        
        // // task4
        // Console.WriteLine("enter the password of spart to code");
        // string pass = Console.ReadLine();
        // while (pass != "Spark2026")
        // {
        //     Console.WriteLine("enter the password of spart to code");
        //     pass = Console.ReadLine();
        // }
        //
        // Console.WriteLine("Access Granted");
        
        //task5 
        int attempt = 0;
        int attempted_number;
       
        do
        {
            Console.Write("enter the secret number");               
            attempted_number = int.Parse(Console.ReadLine());   

            if (attempted_number > 42)
            {
                Console.WriteLine("too high");
            }
            else if (attempted_number < 42)
            {
                Console.WriteLine("too low");
            }




        } while (attempted_number != 42);
        Console.WriteLine("that's correct");
     
    }  }


  
        





