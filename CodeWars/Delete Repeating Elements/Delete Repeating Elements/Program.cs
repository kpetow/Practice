using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, and now they want to show Charlie their entire collection. 
 * However, Charlie doesn't like these sessions, since the motive usually repeats. He isn't fond of seeing the Eiffel tower 40 times. 
 * He tells them that he will only sit during the session if they show the same motive at most N times. Luckily, Alice and Bob are able to encode the motive as a number. 
 * Can you help them to remove numbers such that their list contains each number only up to N times, without changing the order?

 Task
    Given a list lst and a number N, create a new list that contains each number of lst at most N times without reordering. 
    For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, 
    and then take 3, which leads to [1,2,3,1,2,3].
 */

namespace Delete_Repeating_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 3, 7, 2, 2, 2, 2 };
            int x = 3;

            int count = 0;
            int aux = 0;

            Dictionary<int, int> list = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                list.Add(aux, i);
                aux++;
            }

            for(int j = arr.Length - 1; j >= 0; j--)
            {
                count = list.Count(b => b.Value == arr[j]); 
                if (count > x)
                {                    
                    list.Remove(j);                    
                }        
            }
            int[] result = list.Values.ToArray();
            foreach (int num in result) { Console.Write(num + " "); }
            Console.WriteLine();
        }
    }
}
