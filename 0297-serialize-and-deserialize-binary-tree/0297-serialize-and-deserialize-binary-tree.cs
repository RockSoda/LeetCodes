/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec 
{

    // Encodes a tree to a single string.
    private Dictionary<int, List<(int, int, int)>> map;
    
    private void Load(TreeNode node, int level)
    {
        if(node == null) return;
        
        if(!map.ContainsKey(level)) map[level] = new List<(int, int, int)>();
        
        map[level].Add((node.val, node.left == null ? 1001 : node.left.val, node.right == null ? 1001 : node.right.val));
    
        Load(node.left, level+1);
        Load(node.right, level+1);
    }
    
    public string serialize(TreeNode root) 
    {
        map = new Dictionary<int, List<(int, int, int)>>();
        
        Load(root, 0);
        
        var sb = new StringBuilder();
        
        foreach(var kvp in map)
        {
            sb.Append("l");
            foreach(var node in kvp.Value)
                sb.Append(node.Item1+":"+node.Item2+","+node.Item3+".");
        }
        return sb.ToString();
    }

    private void Load(string data)
    {
        var list = data.Split('l', StringSplitOptions.RemoveEmptyEntries);
        
        for(int i = 0; i < list.Length; i++)
        {
            map[i] = new List<(int, int, int)>();
            var subL = list[i].Split('.', StringSplitOptions.RemoveEmptyEntries);
            foreach(var pNc in subL)
            {
                var tmp1 = pNc.Split(':', StringSplitOptions.RemoveEmptyEntries);
                var parent = int.Parse(tmp1[0]);
                var tmp2 = tmp1[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
                var left = int.Parse(tmp2[0]);
                var right = int.Parse(tmp2[1]);
                map[i].Add((parent, left, right));
            }
        }
    }
    
    private void ConstructTree(TreeNode node, int level)
    {
        if(!map.ContainsKey(level) || node == null) return;
        
        
        var found = map[level].First(x => x.Item1 == node.val);
        int left = found.Item2;
        int right = found.Item3;
        map[level].Remove(found);
        
        if(left != 1001) node.left = new TreeNode(left);
        if(right != 1001) node.right = new TreeNode(right);
        
        ConstructTree(node.left, level+1);
        ConstructTree(node.right, level+1);
    }
    
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) 
    {
        map = new Dictionary<int, List<(int, int, int)>>();
        
        Load(data);
        
        if(!map.ContainsKey(0)) return null;
        
        TreeNode root = new TreeNode(map[0].First().Item1);
        
        ConstructTree(root, 0);
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));