using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Understand problem, get slice of two unless it's an odd number.
        // Disregard example of set of 4, it just would set of two slices.
        // Get the average for slices of 2 or 3 elements.
        int sumOf2 = int.MaxValue;
        int sumOf3 = int.MaxValue;
        int minIdxOf2 = int.MinValue;
        int minIdxOf3 = int.MinValue;

        //Create a for loop that will loop through every element in array, and also get the current iterated index.
        for(int i = 0; i < A.Length - 1; i++) {
            int itm1 = A[i];
            int itm2 = A[i + 1];
            int currentSumOf2 = itm1 + itm2;
            if(currentSumOf2 < sumOf2) {
                sumOf2 = currentSumOf2;
                minIdxOf2 = i;
            }
            //If they are still 3 element, meaning they are two elements after the current iterated element in the array, then set the sumOf3.
            
            if(A.Length > 2 && i < A.Length - 3) {
                int itm3 = A[i + 2];
                int currentSumOf3 = itm1 + itm2 + itm3;
                if(currentSumOf3 < sumOf3) {
                    sumOf3 = currentSumOf3;
                    minIdxOf3 = i;
                }
            }
        }
        //When calculating the average use double since it would round the number when it/s not a floating number type.
        double averageMinSum2 = (double)sumOf2 / 2;
        double averageMinSum3 = (double)sumOf3 / 3;
        if(averageMinSum2 < averageMinSum3)
            return minIdxOf2;
        
        if(averageMinSum3 < averageMinSum2)
            return minIdxOf3;
        
        return Math.Min(minIdxOf2, minIdxOf3);
    }
}