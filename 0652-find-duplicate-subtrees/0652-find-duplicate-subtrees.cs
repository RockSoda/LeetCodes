/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    class Codec 
    {
        private Dictionary<int, List<(int, int, int)>> map;

        private void Load(TreeNode node, int level)
        {
            if(node == null) return;

            if(!map.ContainsKey(level)) map[level] = new List<(int, int, int)>();

            map[level].Add((node.val, node.left == null ? 201 : node.left.val, node.right == null ? 201 : node.right.val));

            Load(node.left, level+1);
            Load(node.right, level+1);
        }
        
        // Encodes a tree to a single string.
        public string Serialize(TreeNode root) 
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

            if(left != 201) node.left = new TreeNode(left);
            if(right != 201) node.right = new TreeNode(right);

            ConstructTree(node.left, level+1);
            ConstructTree(node.right, level+1);
        }

        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data) 
        {
            map = new Dictionary<int, List<(int, int, int)>>();

            Load(data);

            if(!map.ContainsKey(0)) return null;

            TreeNode root = new TreeNode(map[0].First().Item1);

            ConstructTree(root, 0);

            return root;
        }
    }
    
    private Codec Codex;
    
    private Dictionary<string, List<string>> dict;
    
    private void Recurse(TreeNode node)
    {
        if(node == null) return;
        
        var serialized = Codex.Serialize(node);
        if(dict.ContainsKey(serialized)) dict[serialized].Add(Codex.Serialize(node));
        else dict[serialized] = new List<string>{ Codex.Serialize(node) };
        
        Recurse(node.left);
        Recurse(node.right);
    }
    
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) 
    {
        Codex = new Codec();
        dict = new Dictionary<string, List<string>>();
        
        Recurse(root);
        
        var serializedoutput = new HashSet<string>();
        foreach(var kvp in dict)
        {
            if(kvp.Value.Count > 1) 
            {
                foreach(var serializedNode in kvp.Value)
                    serializedoutput.Add(serializedNode);
            }
        }
        
        var output = new List<TreeNode>();
        foreach(var node in serializedoutput) output.Add(Codex.Deserialize(node));
        
        return output;
    }
}