using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // DO A EFFICIENT algorithm that will get the smallest possible positive integer from an array of numbers.
        // Analyze the sample data: [1, 2, 3] -> the smallest possible positive integar is 4.
        // [-1, -3] -> the next positive integar should be 1, since all integar's in array is less than 0.
        //Edge case if the array has no items.
        if(A.Length == 0) return 1;

        // Get the max number.
        int maxNum = A.Max();
        int maxCounter = 1;

        //In cases when all numbers are negative.
        if(maxNum <= 0) return 1;

        while(A.Contains(maxCounter))
            maxCounter++;

        //If each number is present, indicating that the counter is zero, then return the next positive number;            
        if(maxCounter == 0) 
            return maxNum + 1;

        //If it's missing the number, then return the maxCounter which would be the smallest positive integar that does not occur in A.
        return maxCounter;
    }
}