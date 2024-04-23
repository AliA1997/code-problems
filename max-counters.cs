using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // Implement your solution here
        // Look at the sample data, based on the sample, if the current element in the array is the max counter, 
        //then reset all values in the counter's tuple to be the max counter.
        int[] counters = new int[N];
        int currentMaxCounter = 1;
        int maxCounterInd = N + 1;

        for(int i = 0; i <= A.Length - 1; i++) {
            int itm = A[i];
            int itmIdx = itm - 1;
            // Console.WriteLine($"itm: {itm}");
            // Console.WriteLine($"A Length: {A.Length}");
            if(itm == maxCounterInd) {
                currentMaxCounter = counters.Max();
                ResetCounters(counters, currentMaxCounter);
            } else {
                counters[itmIdx] = counters[itmIdx] + 1;
            } 
        }

        return counters;
    }
    
    private void ResetCounters(int[] counters, int currentMaxCounter) 
    {
        for(int j = 0; j <= counters.Length - 1; j++) {
            counters[j] = currentMaxCounter;
        }
        Console.WriteLine(string.Join(", ", counters));
    }
}