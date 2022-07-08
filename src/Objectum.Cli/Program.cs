namespace Objectum.Cli;

public class Program
{
    public static void Main()
    {
#if F
        Console.WriteLine("F");
#else
        Console.WriteLine("No F");
#endif

#if H
        Console.WriteLine("H");
#else
        Console.WriteLine("No H");
#endif
    }
}
