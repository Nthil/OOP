using System.Reflection.Metadata.Ecma335;

namespace MyProject;
/*class Sum
{
    public int RSum()
    {
        int a, b;
        Console.Write("Please enter a number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        b = int.Parse(Console.ReadLine());

        int c = a + b;
        return c;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Sum CS = new Sum();
        Console.WriteLine("C= " + CS.RSum());
        Console.WriteLine("D= " + CS.RSum());
        Console.WriteLine("E= " + CS.RSum());
        Console.ReadKey();
    }
}
/*class Program
{
    static int RSum() 
    {
    int a, b;
    Console.Write("Please enter a number: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Please enter a number: ");
    b = int.Parse(Console.ReadLine());

    int c = a + b;
    return c;

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.ReadKey();

        Console.Write("C= " + RSum());
        Console.ReadKey();
    }
}*/

/*public class funcexer3
{
    public static int Sum() //function "Sum" takes 2 parameters
    {
        int a, b;
        Console.Write("Please enter a number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        b = int.Parse(Console.ReadLine());

        int c = a + b;
        return c;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("\nThe sum of two numbers is : " + Sum());
        Console.ReadKey();
    }
}
*/
public class RSum
{
    public int Sum(int a, int b)
    {
        Console.WriteLine("You enter 2 numbers: " + a + b);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
        int b = int.Parse(Console.ReadLine());

        Sum(a,b);
        Console.ReadKey();
    }
}