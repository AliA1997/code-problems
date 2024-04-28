using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public class Triangle {
        public int P {get;set;}
        public int Q {get;set;}
        public int R {get;set;}
    }
    public int solution(int[] A) {
        // Implement your solution here
        // Find the number of triangles from array
        // A triangle (P, Q, R) is when P + Q > R, Q + R > P, A + R > Q
        // Use the caterpillar method
        int n = A.Length;
        int totalTriangles = 0;

        for(int front = 0; front <= n - 2; front++) {
            int back = n - 1;
            for(int mid = 1; mid < n - 1; mid++) {
                while(back >= 2 && indexesUnique(front, mid, back) && isTriangle(A[front], A[mid], A[back]) ) {
                    back--;
                    totalTriangles += 1;
                }
            }
            
        }

        return totalTriangles;
    }

    private bool indexesUnique(int pIdx, int qIdx, int rIdx)
    {
        var indexes = new int[] { pIdx, qIdx, rIdx };
        return indexes.Distinct().Count() == 3;
    }

    private bool isTriangle(int P, int Q, int R) 
    {
        // Console.WriteLine($"isTriangle:({P}, {Q}, {R})");
        var edge1 = P + Q > R;
        var edge2 = Q + R > P;
        var edge3 = P + R > Q;
        // Console.WriteLine($"isTriangle edges:(edge1:{edge1}, edge2{edge2}, edge3{edge3})");
        return (edge1 && edge2 && edge3);
    }
}