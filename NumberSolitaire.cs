using System;

class Solution {
    public int solution(int[] A) {
        int[] result = new int[A.Length];
        
        for(int i = 0; i < A.Length; i++) {
            int maxMoveOnThisSquare = int.MinValue;
            var firstItemInArr = i == 0;

            if(firstItemInArr){
                result[i] = A[i];
            } else {
                // Loop through the possible dice rolls (1 to 6)
                for(int j = 1; j <= 6; j++) {
                    if(i - j >= 0) {
                        //Make you are adding the current item, and current move to get the index.
                        maxMoveOnThisSquare = Math.Max(maxMoveOnThisSquare, result[i - j] + A[i]);
                    }
                    result[i] = maxMoveOnThisSquare;
                }
                
            }
        }
        
        return result[result.Length - 1];
    }
}
