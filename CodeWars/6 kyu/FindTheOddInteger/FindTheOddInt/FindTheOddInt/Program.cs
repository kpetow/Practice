//Given an array of integers, find the one that appears an odd number of times.

//There will always be only one integer that appears an odd number of times.

//Examples
//[7] should return 7, because it occurs 1 time (which is odd).
//[0] should return 0, because it occurs 1 time (which is odd).
//[1,1,2] should return 2, because it occurs 1 time (which is odd).
//[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
//[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd)

using System.Linq;
using System.Collections.Generic;

class Class
{
    static void Main(string[] args)
    {
        int[] numArray = { -1, 1, 0, 1, 0 };
        int[] checkNum = new int[numArray.Length];
        int check = 0;

        Dictionary<int, int> nums = new Dictionary<int, int>();

        for (int i = 0; i < numArray.Length; i++)
        {
            checkNum[i] = numArray[i];
            //Console.WriteLine(nums[i+1]);
        }

        for (int j = 0; j < numArray.Length; j++)
        {
            for (int k = 0; k < checkNum.Length; k++)
            {
                if (checkNum[k] == numArray[j])
                {
                    check++;
                }
                else
                {
                    check = check + 0;
                }
                //Console.WriteLine($"{numArray[j]} has appeared {check} times");
            }
            if (check % 2 == 0)
            {
                check = 0;
            }
            else
            {
                Console.WriteLine($"The number {numArray[j]} appears an odd amount of times ({check})");
                break;
            }
        }
    }
}