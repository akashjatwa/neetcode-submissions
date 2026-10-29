public class MyHashSet {

    private bool[] mySet = new bool[1000001];


    public MyHashSet() {
    }
    
    public void Add(int key) {
        mySet[key] = true;
    }
    
    public void Remove(int key) {
        mySet[key] = false;
    }
    
    public bool Contains(int key) {
        return mySet[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */