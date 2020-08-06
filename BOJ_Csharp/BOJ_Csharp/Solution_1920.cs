using System;
using System.Linq;

public class Program_1920
{
	static void Main()
	{
        Solution_1920();
	}

    public static void Solution_1920()
    {
        var N = int.Parse(Console.ReadLine());
        var listed = Console.ReadLine().Split().Select(x => int.Parse(x));
        var M = int.Parse(Console.ReadLine());
        var candidiates = Console.ReadLine().Split().Select(x => int.Parse(x));
        if (listed.Any(M))
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
