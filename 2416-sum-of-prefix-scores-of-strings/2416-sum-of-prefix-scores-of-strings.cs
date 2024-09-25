public class Solution 
{
    public class Trie 
    {
        Trie[] children { get; set; }
        int numOfVisit { get; set; }

        public Trie() 
        {
            children = new Trie[26];
            numOfVisit = 0;
        }
        
        public void Insert(string word) 
        {
            var currTrie = this;
            foreach(var c in word)
            {
                int idx = c-'a';
                if(currTrie.children[idx] == null) currTrie.children[idx] = new Trie();
                
                currTrie = currTrie.children[idx];
                currTrie.numOfVisit++;
            }
        }
        
        public int GetNumOfVisit(string word) 
        {
            var output = 0;

            Trie currTrie = this;
            
            foreach(var c in word)
            {
                int idx = c-'a';
                currTrie = currTrie.children[idx];
                output += currTrie.numOfVisit;
            }
            return output;
        }
    }

    public int[] SumPrefixScores(string[] words) 
    {
        var trie = new Trie();
        foreach(var word in words) trie.Insert(word);
        
        var scores = new int[words.Length];
        for(int i = 0; i < words.Length; i++) 
        {
            var word = words[i];
            scores[i] = trie.GetNumOfVisit(word);
        }

        return scores;
    }
}