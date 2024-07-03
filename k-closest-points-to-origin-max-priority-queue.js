/**
 * @param {number[][]} points
 * @param {number} k
 * @return {number[][]}
 */
var kClosest = function(points, k) {
    /**
        Formula
        x squared + y squared
        sqrt(x^2 + y^2) 
        Just comparing the distance between x and y.

        (9, 4) 9 > 4
        (3, 2) 3 > 2
        Average sorting time (n log n)
        Fastest sorting time (n log k) -> k is less than n.
     */
     // Max Heap - Maximum size of k
    const maxHeap = new MaxPriorityQueue();
    for(const [x, y] of points) {
        let d = returnDistance(x, y);
        maxHeap.enqueue([x, y], d);
        // Once maxheap size is greater than k then remove last item.
        if(maxHeap.size() > k) {
            //Remove the top element when maxQueue is less than k remove top element.
            maxHeap.dequeue();
        }
    }

    let results = [];
    while(maxHeap.size())
        results.push(maxHeap.dequeue().element);
    

    return results;
    
};

const returnDistance = (x, y) => x*x + y*y;
