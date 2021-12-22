using System;

/*
 * A Narcissistic Number is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. 
 * In this Kata, we will restrict ourselves to decimal (base 10).

        For example, take 153 (3 digits), which is narcisstic:

            1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
            
        and 1652 (4 digits), which isn't:

            1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938

    The Challenge:
        Your code must return true or false (not 'true' and 'false') depending upon whether the given number is a Narcissistic number in base 10. This may be True and False in your language, e.g. PHP.
        Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers will be passed into the function.
*/


public class Kata
{

    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.Write("Enter an integer:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            char[] aux = value.ToString().ToCharArray();
            int[] digits = new int[aux.Length];
            int sum = 0;

            Console.WriteLine($"String length is {aux.Length}");
            Console.WriteLine(aux[1]);


            for (int i = 0; i < aux.Length; i++)
            {
                digits[i] = aux[i] - '0';
                Console.WriteLine($"Array Value {i+1}: {digits[i]}");
            }

            for (int j = 0; j < digits.Length; j++)
            {
                sum = sum + (int)Math.Pow(digits[j], digits.Length);
            }
            if (sum == value)
            {
                //return true;
                Console.WriteLine("true: value IS narcissistic");
                Console.WriteLine(sum);
            }
            else
            {
                //return false;
                Console.WriteLine("false: value IS NOT narcissistic");
                Console.WriteLine(sum);

            }
            Console.Write("Continue?");
            string check = Console.ReadLine();
            if (check == "y")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }
    }
}
