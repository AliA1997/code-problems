/**
 * @param {number[]} arr
 * @param {number} k
 * @param {number} x
 * @return {number[]}
 */
var findClosestElements = function(arr, k, x) {
    let closestElements = arr.slice(0, k);
    for (let i = 0; i < arr.length - (k + 1); i++) {
        const snapshot = arr.slice(i, k + i);
        const currDistanceTotal = Math.abs(snapshot[0] - k) + Math.abs(snapshot[snapshot.length - 1] - k);
        const closestElementDistanceTotal = Math.abs(closestElements[0] - k) + Math.abs(closestElements[closestElements.length - 1] - k);
        if (closestElementDistanceTotal > currDistanceTotal) {
            closestElements = snapshot;
        }
    }
    console.log(closestElements);
    return closestElements;
};