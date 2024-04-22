using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Look at sample data, [3, 4, 3, 2, 3, -1, 3, 3] 3 is dominator because  it occurs more than half length of array, and the last index is greater is 7.
        int dominator = -1;
        int dominatorIdx = -1;
        Dictionary<int, int> counters = new Dictionary<int, int>();

        for(int i = 0; i < A.Length; i++) {
            int itm = A[i];
            if(!counters.ContainsKey(itm)) {
                counters[itm] = 1;
            } else {
                counters[itm] = counters[itm] + 1;
            }

            if(counters[itm] > A.Length / 2 && dominator < 0) {
                dominator = itm;
                dominatorIdx = i;
            }
        }

        return dominatorIdx;
    }
}