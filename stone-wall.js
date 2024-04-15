// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(H) {
    // Implement your solution here
    let numberOfBlocks = 0;
    const stack = [];

    for(let i = 0; i < H.length; i++){
        var currItem = H[i];
        while(stack.length > 0 && stack[stack.length - 1] > currItem) {
            stack.pop();
        }
        if(stack.length > 0 && stack[stack.length - 1] == currItem) {
        } else {
            numberOfBlocks++;
            stack.push(currItem);
        }
    }
    
    return numberOfBlocks;
}