using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Sort array from least to greatest, and copy the array as well.
        var copyOfA = new int[A.Length];
        Array.Copy(A, copyOfA, A.Length);
        Array.Sort(copyOfA);
        var leader =  copyOfA[copyOfA.Length - 1] * copyOfA[copyOfA.Length - 2] * copyOfA[copyOfA.Length - 3];
        
        return leader;
    }
}