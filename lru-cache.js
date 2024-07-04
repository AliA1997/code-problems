/**
 * @param {number} capacity
 */
var LRUCache = function(capacity) {
    this.map = new Map();
    this.capacity = capacity;
};

/** 
 * @param {number} key
 * @return {number}
 */
 // LRUCache has a capacity and Map
//  put with key and value
// - if we found we replace
// - if we do not found, we add
// - if we want to add but theere is no capacity, we delete 1
LRUCache.prototype.get = function(key) {
    if(!this.map.has(key)) return -1;
    const val = this.map.get(key);
    this.map.delete(key);
    this.map.set(key, val);
    return val;
};

/** 
 * @param {number} key 
 * @param {number} value
 * @return {void}
 */
LRUCache.prototype.put = function(key, value) {
    this.map.delete(key);
    this.map.set(key, value);
    if(this.map.size > this.capacity) {
        const firstItem = this.map.keys().next().value;
        this.map.delete(firstItem);
    }

};

/** 
 * Your LRUCache object will be instantiated and called as such:
 * var obj = new LRUCache(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */