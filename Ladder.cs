using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int[] B) {
        // Implement your solution here
        int[] result = new int[A.Length];
        // Get the max number to restart fibonacci
        int maxA = 0;
        for(int i = 0; i <= A.Length - 1; i++) {
            maxA = Math.Max(maxA+1, A[i]);
        } 

        //Get the fibonacci numbers.
        int[] fibs = new int[A.Length + 1];
        fibs[0] = 1;
        fibs[1] = 1;
        for(int j = 2; j < A.Length + 1; j++) {
            var num1 = fibs[j - 2];
            var num2 = fibs[j - 1];
            fibs[j] = (num1 + num2) % (int)Math.Pow(2, 30);
        }

        for(int i = 0; i <= B.Length - 1; i++) {
            var itm = B[i];
            int m = (int)Math.Pow(2, itm);
            result[i] = fibs[A[i]] % m;
        }

        return result;
    }
}
