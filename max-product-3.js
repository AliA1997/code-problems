// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // Implement your solution here
    let max3 = -Infinity;
    let max2 = -Infinity;
    let max1 = -Infinity;
    let min2 = Infinity;
    let min1 = Infinity;
    let maxTripletProduct = null;
    for(var itm in A) {
        if(itm > max1) {
            max3 = max2;
            max2 = max1;
            max1 = itm;
        } else if(itm > max2) {
            max3 = max2;
            max2 = itm;
        } else {
            max3 = itm;
        }

        if(itm < min1) {
            min2 = min1;
            min1 = itm;
        } else {
            min2 = itm;
        }
    }

    const productOfMaxes = max1 * max2 * max3;
    const productOfMins = max1 * min1  * min2;

    return Math.max(productOfMaxes, productOfMins);
}
