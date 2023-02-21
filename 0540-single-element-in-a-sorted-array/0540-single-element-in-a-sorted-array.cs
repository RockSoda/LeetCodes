public class Solution 
{
    public int SingleNonDuplicate(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;
        try
        {
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] != nums[mid-1] && nums[mid] != nums[mid+1]) return nums[mid];
                else if(nums[mid-1] == nums[mid])
                {
                    if((mid + 1) % 2 == 0) left = mid + 1;
                    else right = mid - 1;
                }
                else
                {
                    if((mid + 1) % 2 == 0) right = mid - 1;
                    else left = mid + 1;
                }
            }

            return nums[left];
        }
        catch(Exception ex)
        {
            return nums[left];
        }
    }
}