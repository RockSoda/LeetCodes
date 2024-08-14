public class Trie 
{
    Trie[] children { get; set; }
    bool isEndOfWord { get; set; }
    
    public Trie() 
    {
        children = new Trie[26];
        isEndOfWord = false;
    }
    
    public void Insert(string word) 
    {
        var currTrie = this;
        foreach(var c in word)
        {
            int idx = c-'a';
            if(currTrie.children[idx] == null) currTrie.children[idx] = new Trie();
            
            currTrie = currTrie.children[idx];
        }
        
        currTrie.isEndOfWord = true;
    }
    
    public bool Search(string word) 
    {
        if(!StartsWith(word, out Trie currTrie)) return false;
        
        return currTrie.isEndOfWord;
    }
    
    private bool StartsWith(string prefix, out Trie currTrie)
    {
        currTrie = this;
        
        foreach(var c in prefix)
        {
            int idx = c-'a';
            if(currTrie.children[idx] == null) return false;
            
            currTrie = currTrie.children[idx];
        }
        
        return true;
    }
    
    public bool StartsWith(string prefix) 
    {
        return StartsWith(prefix, out Trie currTrie);
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */