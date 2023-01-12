public class Solution 
{
    class Node
    {
        public int val = -1;
        public List<Node> children;
        public int[] map;
    }
    
    private void ConstructTree(Node node, string labels, Dictionary<int, List<int>> map, HashSet<int> visited, int[] output, int curr = 0)
    {
        if(visited.Contains(curr)) return;
        
        node.val = curr;
        node.children = new List<Node>();
        node.map = new int[26];
        node.map[labels[curr]-'a']++;
        
        visited.Add(curr);
        
        foreach(var next in map[curr])
        {
            var child = new Node();
            ConstructTree(child, labels, map, visited, output, next);
            if(child.val == -1) continue;
            
            node.children.Add(child);
            for(int i = 0; i < 26; i++)
                node.map[i] += child.map[i];
        }
        
        output[curr] = node.map[labels[curr]-'a'];
    }
    
    public int[] CountSubTrees(int n, int[][] edges, string labels) 
    {
        var map = new Dictionary<int, List<int>>();
        for(int i = 0; i < edges.Length; i++)
        {
            if(!map.ContainsKey(edges[i][0])) map[edges[i][0]] = new List<int>();
            map[edges[i][0]].Add(edges[i][1]);
            
            if(!map.ContainsKey(edges[i][1])) map[edges[i][1]] = new List<int>();
            map[edges[i][1]].Add(edges[i][0]);
        }
        
        var root = new Node();
        var output = new int[n];
        
        ConstructTree(root, labels, map, new HashSet<int>(), output);
        
        return output;
    }
}