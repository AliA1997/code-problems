// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // Implement your solution here'
    var n = A.length;
    var arrWithNItems = new Array(n).fill(0);
    var expectedTotal = arrWithNItems.reduce((t, _, idx) => t += idx + 1, 0);
    var actualTotal = Array.from(new Set([...A])).reduce((t, itm) => t += itm, 0);

    return actualTotal === expectedTotal ? 1 : 0;
}