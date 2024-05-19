public class LRUCache {

    private class UsedKeyItem {
        public object Key {get;set;}
        public int Priority {get;set;}
    }

    public int Capacity { get; set; }
    public Hashtable CacheMap { get; set; }
    private List<UsedKeyItem> RecentlyUsedKeys { get; set; }

    // Should have a capacity of the number of key value pairs it can hold.
    public LRUCache(int capacity)
    {
        Capacity = capacity;
        CacheMap = new Hashtable();
        RecentlyUsedKeys = new List<UsedKeyItem>();
        Console.WriteLine("Instantiated!");
    }

      // Get should return the value of key, if the key exists else return -1.
    public int Get(object key)
    {
        Console.WriteLine($"Key: {CacheMap.ContainsKey(key)}");
        if (CacheMap[key] != null) {
            SetKeyAsUsed(key, 1);
            return (int)CacheMap[key]; 
        }
        return -1;
    }
      // Update the value of the key, if the key exists, otherwise add key-value pair to cache.
      // If # of keys exceed capaicty of operation, remove recently used key
      // A key is considered used when get or put is called on it.
      // Can order values on based on how recently they were used.
      // Called O(1) time, used to store hashmap.
      // Need a Hashmap data structure that moves to the end of the 
    public void Put(int key, int value)
    {

        var isCacheAtMaxCapacity = CheckCacheMapIsOverCapacity();
        if (isCacheAtMaxCapacity) {
            
            ();
        }
        SetKeyAsUsed(key, 2);

        if (CacheMap.ContainsKey(key))
            CacheMap[key] = value;
        else
            CacheMap.Add(key, value);
    }

    private bool CheckCacheMapIsOverCapacity()
    {
        var counter = 0;
        foreach(object key in CacheMap.Keys)
        {
            Console.WriteLine(key);
            counter++;
        }

        return counter == Capacity;
    }


    private void RemoveRecentlyUsedKey()
    {
        var indexOfPriority2 = RecentlyUsedKeys.FindIndex(uk => uk.Priority == 2);
        var indexOfPriority1 = RecentlyUsedKeys.FindIndex(uk => uk.Priority == 1);

        var indexToRemove = indexOfPriority2 != -1 ? indexOfPriority2 : indexOfPriority1;
        if(indexToRemove != -1) {
            RecentlyUsedKeys.RemoveAt(indexToRemove);
        }

    }

    private void SetKeyAsUsed(object key, int priority) {
        var item = new UsedKeyItem() { Key = key, Priority = priority };
        var idxOfItem = RecentlyUsedKeys.FindIndex(uk => uk.Key == key);
        if(idxOfItem != -1)
            RecentlyUsedKeys.RemoveAt(idxOfItem);

        RecentlyUsedKeys.Append(new UsedKeyItem() { Key = key, Priority = priority });

    }
}
