using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
class Solution {
    public int solution(int X, int Y, int D) {
        // Implement your solution here
        // Get the distance between x & y 
        double distance = Y - X;
        // the get the minimum number of jump from the distance to Y via dividing it by D or number of steps/
        double jumps = Math.Ceiling(distance/D);
        Console.WriteLine($"Number of jumps:{jumps}");

        return (int)jumps;

    }
}