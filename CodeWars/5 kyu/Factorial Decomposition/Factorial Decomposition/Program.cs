using System;
using System.Linq;
using System.Collections.Generic;

//had to look up the solution. couldn't figure this one out

static class FactDecomp
{
    static void Main(string[] args)
    {
        int fact = int.Parse(Console.ReadLine());
        Console.WriteLine(Decomp(fact));
    }
    public static string Decomp(int n)
    {
        var result = string.Empty;
        return Enumerable.Range(2, n - 1)
          .Select(x => x.Multipliers())
          .SelectMany(x => x)
          .GroupBy(x => x)
          .OrderBy(x => x.Key)
          .Aggregate(result, (res, x) => res + $" * {x.Key}" + (x.Count() > 1 ? $"^{x.Count()}" : ""))
          .Trim(' ', '*');
    }

    public static IEnumerable<int> Multipliers(this int number)
    {
        var divider = 2;
        while (number != 1)
        {
            if (number % divider == 0)
            {
                number /= divider;
                yield return divider;
            }
            if (number % divider != 0) divider++;
        }
    }
}