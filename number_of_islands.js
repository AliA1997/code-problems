/**
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function(grid) {
    // Find the number of islands
    // Water is represented by zero
    // An island is a 1 that has 0 on north, south, east and west.
    // Way to solve this, is a depth first search
    // Binary tree algorithm
    // Examine Sample data
    //  1, 1, 0, 0, 0
    // 1, 1, 0, 0, 0
    // 0, 0, 1, 0, 0
    // 0, 0, 0, 1, 1
    //Examine results 
    //-> array indexes of [0][0], [0][1], [1][0], [1][1] is one island
    //-> array indexes of [2][2] is the second island
    //-> array indexes of [3][3], [3][4] is the third island
    let numOfIslands = 0;
    if(!grid.length) {
        return 0;
    }
    //Add another indicator, to indicate if land has been visited.\\\
    for(let y = 0; y < grid.length; y++) {
        const numOfRows = grid[y].length;
        for(let x = 0; x < numOfRows; x++) {
            const numOfCols = grid[x].length;
            if(grid[y][x] === '1') {
                markCellAsVisited(grid, x, y, numOfRows, numOfCols);
                numOfIslands++;
            }
        }
    }

    return numOfIslands
};

function markCellAsVisited(grid, x, y, r, c) {
    if(x < 0 || x >= r || y < 0 || y >= c || grid[x][y] === '1')
        return;

    //Make cell as visisted 
    grid[x][y] = '2';

    markCellAsVisited(grid, x+1, y, r, c); //South
    markCellAsVisited(grid, x, y + 1, r, c) // East
    markCellAsVisited(grid, x-1, y, r, c) //North
    markCellAsVisited(grid, x, y - 1, r, c) //West
}