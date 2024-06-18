// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // Implement your solution here
    let result = new Array(A.length);
    const numberOfSidesOnDice = 6;
    for(let i = 0; i < result.length; i++) {
        if(i === 0) {
            result[i] = A[i];
        } else {
            let maxOnThisSquare = Number.MIN_VALUE;
            for(let j= 1; j <= numberOfSidesOnDice; j++) {
                if(i-j >= 0) {
                    maxOnThisSquare = Math.max(maxOnThisSquare, result[i-j] + A[i]);
                }
            }
            result[i] = maxOnThisSquare;
        }
    }

    return result[result.length - 1];
}