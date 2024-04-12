using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public enum StreamDirection {
        Up, Down
    }
    public int solution(int[] A, int[] B) {
        if(A.Length == 0 || B.Length == 0) return 0;
        // Implement your solution here
        var upstreamIdxStack = getUpstreamIndexStack(B);
        var downstreamIdxStack = getDownstreamIndexStack(B);
        var currentDirection = B[0] == 1 ? StreamDirection.Down : StreamDirection.Up;
        var alive = new List<int> { A[0] };

        for(var j = 0; j < A.Length; j++) {
            var currentFish = A[j];
            var didDirectionChange = (currentDirection == StreamDirection.Down && Array.IndexOf(upstreamIdxStack, j) != -1)
                && (currentDirection == StreamDirection.Up && Array.IndexOf(downstreamIdxStack, j) != -1) && alive.Count > 1;


            if(alive.Count > 1) {

                var lastFish = A[j- 1];
                var canFishEatLastFish = currentFish > lastFish;

                if(didDirectionChange){
                    if(canFishEatLastFish) {
                        currentDirection = currentDirection == StreamDirection.Up ? StreamDirection.Down : StreamDirection.Up;
                        alive.Remove(lastFish);
                        alive.Add(currentFish);
                    }
                    
                } else if(canFishEatLastFish) {
                    alive.Remove(lastFish);
                }

            } else {
                    alive.Add(currentFish);
            }
        }

        return alive.Count;
    }
    
    private int[] getUpstreamIndexStack(int[] B) 
    {
        var stack = new List<int>();
        for(var i = 0; i < B.Length; i++) 
        {
            if(B[i] == 0) stack.Add(i);
        }

        return stack.ToArray();
    }

    private int[] getDownstreamIndexStack(int[] B) 
    {
        var stack = new List<int>();
        for(var i = 0; i < B.Length; i++) 
        {
            if(B[i] == 1) stack.Add(i);
        }

        return stack.ToArray();
    }
}