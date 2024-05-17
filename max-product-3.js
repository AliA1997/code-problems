// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // Implement your solution here
    if (A.length < 3) {
        throw new Error("Array must have at least 3 elements.");
    }

    let max1 = -Infinity;
    let max2 = -Infinity;
    let max3 = -Infinity;
    let min1 = Infinity;
    let min2 = Infinity;

    for (let num of A) {
        if (num > max1) {
            max3 = max2;
            max2 = max1;
            max1 = num;
        } else if (num > max2) {
            max3 = max2;
            max2 = num;
        } else if (num > max3) {
            max3 = num;
        }

        if (num < min1) {
            min2 = min1;
            min1 = num;
        } else if (num < min2) {
            min2 = num;
        }
    }

    const positiveProduct = max1 * max2 * max3;
    const negativeProduct = max1 * min1 * min2;

    return Math.max(positiveProduct, negativeProduct);
}