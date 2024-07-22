/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    // Reverse the string
    var reversed = x.toString().split('').reverse().join("");
    return (x.toString() === reversed)
};
// var isPalindrome= function(x) {
//     let reversedStr = '';
//     const xStr = x.toString();
//     for(let i of xStr) { // i reference's each character in the string.
//         reversedStr = i + reversedStr
//         console.log('reversedStr:', reversedStr);
//     }

//     return (reversedStr === xStr);
// }