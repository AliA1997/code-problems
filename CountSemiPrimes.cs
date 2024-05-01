using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] P, int[] Q) {
        // Implement your solution here
        // Get the prime numbers
        // Use nested for loops to calculate the prime numbers.
        List<int> result = new List<int>();
        var allPrimes = GetPrimes(N);
        var semiPrimes = new int[N+1];
        for(int a = 0; a < allPrimes.Length - 1; a++) {
            for(int b = a; b < allPrimes.Length - 1; b++) {
                int primeA = allPrimes[a];
                int primeB = allPrimes[b];
                int productOfPrimes = primeA * primeB;
                if(productOfPrimes >= semiPrimes.Length)
                    break;

                semiPrimes[productOfPrimes] = 1;
            }
        }

        int counter = 0;
        for(int i = 0; i < semiPrimes.Length; i++) {
            counter += semiPrimes[i];
            semiPrimes[i] = counter;
        }



        for(int j = 0; j <= P.Length - 1; j++){
            int start = P[j];
            int end = Q[j];
            result.Add(semiPrimes[end] - semiPrimes[start-1]);
        }

        return result.ToArray();
    }


    private int[] GetPrimes(int N) {
        var limit = N/2;
        var composites = new bool[N+1];
        List<int> primes = new List<int>();        
        for(int a = 2; a < limit; a++) {
            for(int b = a * 2; b <= N; b+=a) {
                composites[b] = true;
            }
        }
        
        for(int i = 2; i <= N; i++) {
            if(!composites[i])
                primes.Add(i);
        }

        return primes.ToArray();
    }