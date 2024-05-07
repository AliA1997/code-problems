// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A, B) {
    // Implement your solution here
    // Indicate what fishes would be left in the river
    // Fishes going upstream would being process of eating fish.
    // Define stack queue.
    const n = A.length;
    const downstreamQueue = [];
    let eatenCounter = 0;
    for (let i = 0; i < n; i++) {
        const itmSize = A[i];
        const itmStreamInd = B[i];
        if (itmStreamInd == 0 && downstreamQueue.length) {
            while (downstreamQueue.length && downstreamQueue[0] < itmSize) {
                downstreamQueue.shift();
            }
            eatenCounter++;
        } else if (itmStreamInd == 1) {
            downstreamQueue.push(itmSize);
        }
    }

    return n - eatenCounter;
}
