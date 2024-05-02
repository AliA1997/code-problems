using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int K, int M, int[] A) {
        // Implement your solution here
        // K is the minimal value.
        // M is the maximal value.
        int min = 0;
        int max = 0;
        foreach(var itm in A) 
        {
            max += itm;
            min = Math.Max(min, itm);
        }

        int bestAnswer = max;

        while(min <= max) {

            int mid = (min + max) / 2;

            // Take mid point, and indicate how many blocks would be divided.
            // Get the number of blocks
            int blocks = checkBlocks(A, mid);
            if(blocks > K) {
                min = mid + 1;
            } else {
                max = mid - 1;
                if(mid < bestAnswer) {
                    bestAnswer = mid;
                }
            }
        }
        return bestAnswer;
        
    }

    private int checkBlocks(int[] A, int guess) {
        int blocks = 1;
        int blocksSum = 0;

        foreach(var itm in A) {
            blocksSum += itm;
            if(blocksSum > guess) {
                blocksSum = itm;
                blocks++;
            }
        }

        return blocks;
    }
}