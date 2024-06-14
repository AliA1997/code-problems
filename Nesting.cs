using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // Implement your solution here
        var sIsEmpty = string.IsNullOrEmpty(S) || string.IsNullOrWhiteSpace(S);
        if(sIsEmpty) return 1;


        int counter = 0;
        for(int i = 0; i < S.Length; i++){
            var currChar = S[i];
            if(currChar == '(') counter++;
            if(currChar == ')') counter--;
            if(counter < 0) return 0;
        }

        return counter == 0 ? 1 : 0;
    }
}
