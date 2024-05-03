using System;
using System.Linq;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Clarify question, get the number of distinct values in the array.
        // Write an efficient method using the caterpillar method, since the array could have 100,000 elements.
        // Prevent iterating over each item. 
        // Try to accomplish in O(n log n) time complexity.
        int l = A.Length - 1;
        int frontOfCaterpillar =  (int)Math.Ceiling((double)l / 2);
        List<int> result = new List<int>();
        for(int backOfCaterpillar = 0; backOfCaterpillar <= l; backOfCaterpillar++){
            var backCaterpillarItem = Math.Abs(A[backOfCaterpillar]);
            var frontCaterpillarItem = Math.Abs(A[frontOfCaterpillar]);
            if(backCaterpillarItem <= int.MinValue || backCaterpillarItem >= int.MaxValue) continue;
            if(frontCaterpillarItem <= int.MinValue || frontCaterpillarItem >= int.MaxValue) continue;
            //Check if the back of the caterpillar has that duplicate item.
            //If it doesn't, add it and continue the loop, or jump to next iteration.
             if(!result.Contains(backCaterpillarItem)) {
                result.Add(backCaterpillarItem);
                continue;
            }

            //If it is in the front of caterpiller, add it and continue the loop, or jump to next iteration.
            if(frontOfCaterpillar >= 1 && !result.Contains(frontCaterpillarItem)) {
                result.Add(frontCaterpillarItem);
                frontOfCaterpillar--;
                continue;
            }
        }

        return result.Count();
    }
}