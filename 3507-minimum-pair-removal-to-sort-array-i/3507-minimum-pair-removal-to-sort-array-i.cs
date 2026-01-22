public class Solution 
{
    public int MinimumPairRemoval(int[] nums) 
    {
        bool IsNonDescreasing(List<int> l)
        {
            for(int i = 1; i < l.Count; i++)
            {
                if(l[i-1] > l[i]) return false;
            }
            return true;
        }

        var list = nums.ToList();

        var steps = 0;
        while(!IsNonDescreasing(list))
        {
            var sum = int.MaxValue;
            int idx = -1;
            for(int i = 1; i < list.Count; i++)
            {
                var currSum = list[i-1] + list[i];
                if(currSum >= sum) continue;

                sum = currSum;
                idx = i;
            }

            list.RemoveAt(idx-1);
            list.RemoveAt(idx-1);
            list.Insert(idx-1, sum);
            steps++;
        }
        return steps;
    }
}