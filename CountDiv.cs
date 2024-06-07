using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // Implement your solution here
        int baseValue = (int)Math.Ceiling((double)A/K);
        baseValue *= K;
        B -= baseValue;
        int count = (int)Math.Floor((double)B / K);
        //Add the number itself to count
        count++;
        return count;
    }
}
