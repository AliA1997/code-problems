using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    internal class TempVariables {
        public int NumberOfOccurancesOfValue {get;set;} = 0;
        public int NumberOfOccurancesOfCandidate {get;set;} = 0;
        public int Value {get;set;} = 0;
        public int Candidate {get;set;} = -1;
        public int Leader {get;set;} = -1;
        public int LeaderCount {get;set;} = -1;
        public void DecreaseNumOfOccurancesOfValue() => NumberOfOccurancesOfValue = NumberOfOccurancesOfValue - 1;
        public void IncreaseNumOfOccurancesOfValue() => NumberOfOccurancesOfValue = NumberOfOccurancesOfValue + 1;
        public void DecreaseNumOfOccurancesOfCandidate() => NumberOfOccurancesOfCandidate = NumberOfOccurancesOfCandidate - 1;
        public void IncreaseNumOfOccurancesOfCandidate() => NumberOfOccurancesOfCandidate = NumberOfOccurancesOfCandidate + 1;
        public void SetValue(int newValue) => Value = newValue;
        public void SetCandidate(int newCandidate) => Candidate = newCandidate;
        public void SetLeader(int newLeader) => Leader = newLeader;
        public void IncreaseLeaderCount() => LeaderCount = LeaderCount + 1;
        public void DecreaseLeaderCount() => LeaderCount = LeaderCount + 1;
    }
    public int[] AToSolve {get;set;}
    public TempVariables TempVars {get;set;} = new TempVariables();
    public int solution(int[] A) {
        // Implement your solution here
        // Try solving this in O(n) time.
        // First check for a candidate.
        AToSolve = A;
        DetermineCandidate();
        DetermineLeader();

        return DetermineLeaderOnLSide();
    }
    private int DetermineLeaderOnLSide() {
        int countRightSide = AToSolve.Length;
        int countLeftSide = 0;
        int leadersLeftSide = 0;
        int equiLeaders = 0;

        for(int i = 0; i < AToSolve.Length; i++) {
            if(AToSolve[i] == TempVars.Leader) {
                //Indicate that they are leaders found in the left side, therefore increment coresponding variables.
                leadersLeftSide = leadersLeftSide + 1;
                TempVars.DecreaseLeaderCount();
            }
            countRightSide = countRightSide - 1;
            countLeftSide = countLeftSide + 1;

            if(leadersLeftSide > countLeftSide / 2) {
                if(TempVars.LeaderCount > countRightSide / 2) {
                    equiLeaders = equiLeaders + 1;
                }
            }
        }
        return equiLeaders;
    }

    private void DetermineCandidate() {
        for(var i = 0; i < AToSolve.Length; i++) {
            if(TempVars.NumberOfOccurancesOfValue == 0) {
                TempVars.IncreaseNumOfOccurancesOfValue();
                TempVars.SetValue(AToSolve[i]);
            } else {
                if(TempVars.Value != AToSolve[i]) TempVars.DecreaseNumOfOccurancesOfValue(); 
                else TempVars.IncreaseNumOfOccurancesOfValue();
            }
        }
        if(TempVars.NumberOfOccurancesOfValue > 0) TempVars.SetCandidate(TempVars.Value);
    }
    private void DetermineLeader() {
        for(var i = 0; i < AToSolve.Length; i++) {
            if(TempVars.Candidate == AToSolve[i]) TempVars.IncreaseNumOfOccurancesOfCandidate();
        }
        if(TempVars.NumberOfOccurancesOfCandidate > AToSolve.Length / 2) {
            TempVars.SetLeader(TempVars.Candidate);
            TempVars.IncreaseLeaderCount();
        }
    }
}