namespace task5;

class Program
{
    static void Main(string[] args)
    {
        string state = " ";
        Console.Write("enter a temperature in Celsius:");
        float tempC = float.Parse(Console.ReadLine());
        float f = ((tempC * 9 / 5) + 32) ;
        if (tempC < 10)
        {
            state= "cold";
        }
        else if (tempC >= 10 && tempC <= 30)
        {
             state = "mid";
        }
        else if (tempC> 30)
        {
             state = "HOT";
        }
        Console.WriteLine($"temprature in Fahrenheit:{f}, classifies to be {state}");
            



    }
}