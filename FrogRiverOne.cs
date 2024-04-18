using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // Implement your solution here
        // Analyze test data.
        // Frog starts at one bank of the river which is zero and goes to the otherside of the river which is X.
        // A[i] indicates the number of seconds of the leave falling, for example at the six second which mean the item with a index of six should be the target leaf
        //Define a list stores all the numbers to X.
        HashSet<int> numsToX = new HashSet<int>();
        int result = -1;

        for(int i = 1; i <= X; i++) {
            numsToX.Add(i);
        }
        //Loop through array, and check if each items is in the nums to x.\
        
        for(int j = 0; j < A.Length; j++) {
            var currItem = A[j];
            if(numsToX.Contains(currItem)) {
                numsToX.Remove(currItem);
                if(numsToX.Count == 0) 
                    result = j;
            }
        }

        Console.WriteLine($"Result:{result}");
        return result;
    }
}