using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // Implement your solution here
        // Find the # of prime divisors in between two arrays.
        // Define a greatest common divisor function to indicate if a pair of numbers have a greatest common divisor.
 
        int gcdCounter = 0;
        for(int i = 0; i < A.Length - 1; i++) {
            int num1 = A[i];
            int num2 = B[i];
            List<int> num1List = greatestCommonDivisors(num1, 2, new List<int>());
            List<int> num2List = greatestCommonDivisors(num2, 2, new List<int>());
            if(num1List.SequenceEqual(num2List))
                gcdCounter++;
        }



        return gcdCounter;
    }

    private bool isPrime(int num) 
    {
        if(num <= 1) return false;
        if(num <= 3) return true;

        if(num % 2 == 0 || num % 3 == 0) return false;

        for(int j = 5; j * j <= num; j+=6){
            // Console.WriteLine($"Test isPrime: {num}");
            if(num % j == 0 || num % (j + 2) == 0)
                return false; 
        }

        return true;
    }

    private List<int> greatestCommonDivisors(int num, int currentDivisor, List<int> divisorList)
    {
        int divisor = currentDivisor;
        if(num <= 1) return divisorList;

        if(num % divisor == 0 && isPrime(divisor))
        {
            divisorList.Add(divisor);
            while(num > 0 && num % divisor == 0){
                num /= divisor;
            }
        }
        divisor++;
        return greatestCommonDivisors(num, divisor, divisorList);
    }
}
