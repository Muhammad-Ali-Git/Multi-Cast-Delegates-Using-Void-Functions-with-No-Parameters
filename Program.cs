// See https://aka.ms/new-console-template for more information
using System;

public delegate void Sample();

public class Ali
{
    public static void Main()
    {
        Console.WriteLine("This Program Prints output of Multi-Cast Delegates.");
        Console.WriteLine("A Multi-Cast Delegate points to more than one function.");
        Console.WriteLine("\n --------------------------------------------------------- \n");
        
        Console.WriteLine("Method-I: Create Multiple Deligates");
        Sample S1, S2, S3, S4;
        S1 = new Sample(Method1);
        S2 = new Sample(Method2);
        S3 = new Sample(Method3);

        S4 = S1 + S2 + S3;  // Multi-Cast Delegate is formed by chaining (adding) delegates together.
        S4();   // Multi-Cast Delegate
        Console.WriteLine("\n --------------------------------------------------------- \n");

        Console.WriteLine("Method-I: Create Single Deligate");
        Sample D = new Sample(Method1);

        D = D + Method2 + Method3;
        D();
    }

    public static void Method1()
    {
        Console.WriteLine("Method 1 Envoked.");
    }
    public static void Method2()
    {
        Console.WriteLine("Method 2 Envoked.");
    }
    public static void Method3()
    {
        Console.WriteLine("Method 3 Envoked.");
    }
}