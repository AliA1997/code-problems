using System;
using System.Collections.Generic;
// you can also use other imports, for example:

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // Get the peaks from each element of the array.
        // After getting the peaks, get the number of flags you would get to go to a certain peak.
        List<int> peaks = new List<int>();
        for(int i = 1; i < A.Length - 1; i++) {
            var itm = A[i];
            if(itm > A[i - 1] && itm > A[i + 1]){
                peaks.Add(i);
            }
        }

        // If their is only one peak or less than one peak, just return 1 or 0.
        if(peaks.Count <= 1) return peaks.Count;

        // Get the max flags in the array, which would be the square of the first peak compared to last peak, in this case is 10(last peak) - 1(first peak) is 3.
        // 3 flags maximum before reaching end peak.
        int maxFlags = (int)Math.Ceiling(Math.Sqrt(peaks[peaks.Count - 1] - peaks[0]));


        var flagsTaken = 0;
        for(int currentFlags = maxFlags; currentFlags > 1; currentFlags--) {
            //Get the start idx
            int startIdx = 0;
            // Get the end idx.
            int endIdx = peaks.Count - 1;

            // Get the starting and ending flag.
            int startFlag = peaks[startIdx];
            int endFlag = peaks[endIdx];

            int flagsPlaced = 2;

            // While the start idx is less than end idx
            while(startIdx < endIdx) {
                startIdx++;
                endIdx--;

                // If start peak is less than the current startFlag + the current flag.
                // 4
                // 7
                if(peaks[startIdx] >= startFlag + currentFlags) {
                    if(peaks[startIdx] <= endFlag - currentFlags){
                        /*
                            Console.WriteLine($"Start Index IF statement hit:{peaks[startIdx]}");
                        Console.WriteLine($"Start Flag IF statement hit:{startFlag}");
                        Console.WriteLine($"End Flag IF statement hit:{endFlag}");
                        Console.WriteLine($"Current Flags IF statement hit:{currentFlags}");
                        */
                        flagsPlaced++;
                        startFlag = peaks[startIdx];
                    }
                }

                if(peaks[endIdx] >= startFlag + currentFlags) {
                    if(peaks[endIdx] <= endFlag - currentFlags){
                    /*
                        Console.WriteLine($"End Index IF statement hit:{peaks[endIdx]}");
                        Console.WriteLine($"Start Flag IF statement hit:{startFlag}");
                        Console.WriteLine($"End Flag IF statement hit:{endFlag}");
                        Console.WriteLine($"Current Flags IF statement hit:{currentFlags}");
                    */
                        flagsPlaced++;
                        startFlag = peaks[endIdx];
                    }
                }

                if(flagsPlaced == currentFlags) return currentFlags;
            }
        }

        return 0;
    }
}
