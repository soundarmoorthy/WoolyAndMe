/*
 Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [¿1, ¿3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [¿1,000,000..1,000,000].

 */

using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution {
    public static void Main(string[] args)
    {

        var res = new Solution().solution(new[] { 1, 3, 6, 4, 1, 2 });
        Console.WriteLine(res);

    }

 public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var large = 0;
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            var item = A[i];
            if (item < 0)
                continue;

            if (item > large)
            {
                large = item;
            }

            if (!set.Contains(item))
                set.Add(item);
        }

        for(int i=1;i<=large;i++)
        {
            if (!set.Contains(i))
                return i;
        }
        return large + 1;
    }
}
