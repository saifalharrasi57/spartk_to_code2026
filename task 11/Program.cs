namespace task_11;

class Program
{
    static void Main(string[] args)
    {
        bool loan = true;
     Console.Write("enter your age ");
     int age = int.Parse(Console.ReadLine());
     Console.Write("enter your monthly income ");
     float salary = float.Parse(Console.ReadLine());
     Console.Write("do you have any loan (yes/no)");
     string value = Console.ReadLine();
     if ( value== "no")
     {
         loan = false;
     }



     if (age >= 21 && age <= 60 && salary > 400 && !loan)
     {
         Console.WriteLine("approved");
     }

     else if( age < 21 || age > 60)
     {

         Console.WriteLine(" age out of range ");
     }
     else if (salary < 400)
     {
         Console.WriteLine("income is too low  ");
         
     }
     else
     {
         Console.WriteLine("has an existing loan");
     }
    }
    
}