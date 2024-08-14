public class Trie 
{
    public class Node
    {
        public Node[] children { get; set; }
        
        public bool isEndOfWord { get; set; }
        
        public Node() 
        {
            children = new Node[26];
        }
    }
    
    Node root;
    
    public Trie() 
    {
        root = new Node();
    }
    
    public void Insert(string word) 
    {
        var currNode = root;
        foreach(var c in word)
        {
            int idx = c-'a';
            if(currNode.children[idx] == null) currNode.children[idx] = new Node();
            
            currNode = currNode.children[idx];
        }
        
        currNode.isEndOfWord = true;
    }
    
    public bool Search(string word) 
    {
        var currNode = root;
        
        if(!StartsWith(word, ref currNode)) return false;
        
        return currNode.isEndOfWord;
    }
    
    private bool StartsWith(string prefix, ref Node currNode)
    {
        foreach(var c in prefix)
        {
            int idx = c-'a';
            if(currNode.children[idx] == null) return false;
            
            currNode = currNode.children[idx];
        }
        
        return true;
    }
    
    public bool StartsWith(string prefix) 
    {
        var currNode = root;
        return StartsWith(prefix, ref currNode);
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */