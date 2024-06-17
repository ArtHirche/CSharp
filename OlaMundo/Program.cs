public class Program
{
    public static void Main(string[] argd)
    {

        Console.WriteLine("Hello, World!"); // output: Hello, World

        var a = 3;
        Console.WriteLine(a); // output: 3
        Console.WriteLine(a++); // output: 3
        Console.WriteLine(a); // output: 4

        
        int b = 3;
        Console.WriteLine(b); // output: 3
        Console.WriteLine(b--); // output: 3
        Console.WriteLine(b); // output: 2

        
        int a1 = 1 + 2 + 3;
        int b1 = 6;
        Console.WriteLine(a1 == b1); // output: True
        Console.WriteLine(a1 != b1); // output: False



        Console.WriteLine(a.GetType()); // output: System.Int32

    
    }

}