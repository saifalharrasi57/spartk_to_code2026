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





        /// task3
        Console.Write("Dear user ,enter number to see its multiplication table  : ");
       
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i += 1)
            {
                int answer = number * i;
                Console.WriteLine($"{number} * {i}= {answer}");
            }
        }
     
    }


    //task5



