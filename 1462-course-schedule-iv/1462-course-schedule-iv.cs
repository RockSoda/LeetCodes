public class Solution 
{
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) 
    {
        var mapPrereq = new Dictionary<int, HashSet<int>>();

        foreach(var prereq in prerequisites)
        {
            var parent = prereq[0];
            var child = prereq[1];
            if(!mapPrereq.ContainsKey(parent)) mapPrereq[parent] = new HashSet<int>();
            mapPrereq[parent].Add(child);
        }
        
        var memo = new Dictionary<(int, int), bool>();
        bool IsPrereq(int parent, int child)
        {
            if(!mapPrereq.ContainsKey(parent)) return false;
            
            if(mapPrereq[parent].Contains(child)) return true;

            if(memo.ContainsKey((parent, child))) return memo[(parent, child)];

            var output = false;
            foreach(var c in mapPrereq[parent])
                output = output || IsPrereq(c, child);
            
            return memo[(parent, child)] = output;
        }

        var output = new List<bool>();
        foreach(var query in queries)
        {
            var parent = query[0];
            var child = query[1];

            output.Add(IsPrereq(parent, child));
        }

        return output;
    }
}