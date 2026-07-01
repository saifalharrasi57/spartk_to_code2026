namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("calculate the rectangle area and perimeter");
        Console.Write("enter Rectangle legnth: ");
        float length = float.Parse(Console.ReadLine());
        Console.Write("enter rectangle width: ");
        float Width = float.Parse(Console.ReadLine());
        float area = length * Width;
        float perimeter = 2 * (length + Width) ;
        Console.WriteLine($"Reactangle Area is :{area}");
        Console.WriteLine($"Perimeter is :{perimeter}");




    }
}