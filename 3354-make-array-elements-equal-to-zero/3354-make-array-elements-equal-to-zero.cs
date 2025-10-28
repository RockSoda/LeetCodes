public class Solution 
{
    public int CountValidSelections(int[] nums) 
    {
        bool IsValidSelection(int[] currNums, int idx, bool isLeft)
        {
            bool currDirIsLeft = isLeft;
            while(idx >= 0 && idx < currNums.Length)
            {
                if(currNums[idx] > 0) 
                {
                    currNums[idx]--;
                    currDirIsLeft = !currDirIsLeft;
                }

                if(currDirIsLeft) idx--;
                else idx++;
            }

            return !currNums.Any(num => num != 0);
        }

        var validSelections = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0) continue;
            
            if(IsValidSelection(nums.ToArray(), i, true)) validSelections++;
            
            if(IsValidSelection(nums.ToArray(), i, false)) validSelections++;
        }

        return validSelections;
    }
}