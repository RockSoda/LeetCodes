public class Trie 
{
    public class Node
    {
        public Dictionary<char, Node> children { get; set; }
        
        public bool isEndOfWord { get; set; }
        
        public Node() 
        {
            children = new Dictionary<char, Node>();
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
            if(!currNode.children.ContainsKey(c)) currNode.children[c] = new Node();
            
            currNode = currNode.children[c];
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
            if(!currNode.children.ContainsKey(c)) return false;
            
            currNode = currNode.children[c];
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