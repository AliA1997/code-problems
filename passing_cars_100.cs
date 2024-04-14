using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Get the passing cars from an array
        // 0 is going east, and 1 is going east, check how many times they intersect.
        // 1st look at the sample data.
        // From an array -> you get the result of (0,1) (0,3)(0,4)(2,3)(2,4) which is five pairs.
        // Count how many cars are going east.\
        // Increment the number of passing cars based on the number of cars going east, since each new car going east would add specific amount based on number of passing cars left.
        //Consider edge case, if it's going over 1 billion return -1.
        int numberOfCarsGoingEast = 0;
        int numberOfPassingCars = 0;

        for(int i = 0; i < A.Length; i++) {
            var itm = A[i];
            if(itm == 0) {
                numberOfCarsGoingEast++;
            } else {
                if(numberOfPassingCars > 1000000000) return -1;
                numberOfPassingCars += numberOfCarsGoingEast;
            }
        }

        return numberOfPassingCars;
    }
}