public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int left = 0, right = height.Length - 1;

        int maxArea = 0;
        while(left <= right)
        {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[right], height[left]));

            if(height[right] > height[left]) left++;
            else right--;
        }

        return maxArea;
    }
}