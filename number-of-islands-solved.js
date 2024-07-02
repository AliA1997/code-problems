/**
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function (grid) {
    //Use depth first search
    // Keep track of what nodes are visited.
    let visited = new Set();
    // Get the number of rows in the grid
    const rows = grid.length;
    // Get the number of columns in the grid
    const cols = grid[0].length;
    let numOfIslands = 0;

    /*
     Strategy
     1) Loop through the grid and find the first occurance of '1',
     2) Increase the island count by 1
     3) Look through it's neighbors and mark them as visited by changing value to 2.
     4) Continue until we can no long find neighboring '1'
     5) Repeat step #1
     6. Find return the count of islands.]
    */
    for(let rowIdx = 0; rowIdx < grid.length; rowIdx++) {
        for(let colIdx = 0; colIdx < grid[0].length; colIdx++) {

            if(grid[rowIdx][colIdx] == '1') {
                numOfIslands++;
                // Look through it's neighbors using depth first search, a binary search tree way of searching it's neighbors.
                // console.log("GRID:", grid);
                dfs(grid, rowIdx, colIdx);
            }
        }
    }

    return numOfIslands;
};

function dfs(grid, row, col) {
    if(row < 0 || col < 0 || row >= grid.length || col >= grid[0].length) return;
    // console.log(row, col);
    // console.log('GRID ROW: ', grid[row], row);
    const value = grid[row][col];
    if(value === '1') {
        grid[row][col] = '2';
        //Look through it's neighbors by checking west, east, north and south.
        //Search west
        dfs(grid, row, (col - 1));
        //Search east
        dfs(grid, row, (col + 1));
        //Search north
        dfs(grid, (row + 1), col);
        //Search south
        dfs(grid, (row - 1), col);
    }
}