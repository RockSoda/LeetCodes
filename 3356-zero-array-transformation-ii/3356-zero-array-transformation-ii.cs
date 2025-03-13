public class Solution 
{
    public int MinZeroArray(int[] nums, int[][] queries) 
    {
        bool CurrentIndexZero(int k)
        {
            var difference = new int[nums.Length+1];
            int sum = 0;

            for(int i = 0; i < k; i++)
            {
                int left = queries[i][0], right = queries[i][1], val = queries[i][2];
                difference[left] += val;
                difference[right+1] -= val;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                sum += difference[i];
                if(sum < nums[i]) return false;
            }
            return true;
        }

        int left = 0, right = queries.Length;

        if(!CurrentIndexZero(right)) return -1;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(CurrentIndexZero(mid)) right = mid - 1;
            else left = mid + 1;
        }

        return left;
    }
}