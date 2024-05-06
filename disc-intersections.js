// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // Implement your solution here
    // Count the number of intersecting discs.
    // On each index of N check the number of discs overlap based on array A.
    // Define vars, length of array, and counter.
    const N = A.length;
    let startPoints = [];
    let endPoints = [];
    let counter = 0;

    // Get the start point and end points 
    for(let i = 0; i < N; i++) {
        const currentItem = A[i];
        //Start and endpoints from subtracting or adding radii from indices
        startPoints.push(i - currentItem);
        endPoints.push(i + currentItem);
    }

    // Get the number of start points less than end points.
    for(let j = 0; j < N; j++) {
        const startPoint = startPoints[j];
        const startPointsLessthanEndpoints = endPoints.filter((ep) => startPoint <= ep).length;
        const resultingStartPointsLessThanEndpointsExcludingOne = startPointsLessthanEndpoints - 1;
        // Get the intersection of the current point subtracting indice from resulting start points less than endpoints.
        const intersectionsAtPoint = resultingStartPointsLessThanEndpointsExcludingOne - j;
        if(counter > 10000000) return -1;
        // Add the defined intersection to total.
        counter += intersectionsAtPoint;
    }

    return counter;
}