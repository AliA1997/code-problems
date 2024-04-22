using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    private int dominator;
    private int dominatorCount;

    public int solution(int[] A) {
        // Implement your solution here
        // Clarify the question, get the equiLeaders, which means most slices that can be generated using dominator
        // For example you can split the array at index 0, which would have two slices with dominators, 
        // and you can split at index 2 as well and it would have two slices with dominators.
        // Get the dominatorCount
        GetDominatorCount(A);
        // Get the dominator 
        var equiLeaders = 0;
        var leadersInRightSide = dominatorCount;
        var countInRightSide = A.Length;
        var leadersInLeftSide = 0;
        var countInLeftSide = 0;
        foreach(var itm2 in A) {
            if(itm2 == dominator) {
                leadersInRightSide--;
                leadersInLeftSide++;
            }
            countInLeftSide++;
            countInRightSide--;
            if(leadersInLeftSide > countInLeftSide / 2) {
                if(leadersInRightSide > countInRightSide / 2) {
                    equiLeaders++;
                }
            }
        }

        return equiLeaders;
    }

    private void GetDominatorCount(int[] A) {
        var counters = new Dictionary<int, int>();
        for(int i = 0; i < A.Length - 1; i++) {
            var itm = A[i];
            if(!counters.ContainsKey(itm)) {
                counters[itm] = 1; 
            } else {
                counters[itm] = counters[itm] + 1;
            }

            if(counters[itm] > A.Length / 2) {
                dominator = itm;
                dominatorCount = counters[itm];
            }
        }
    }
}