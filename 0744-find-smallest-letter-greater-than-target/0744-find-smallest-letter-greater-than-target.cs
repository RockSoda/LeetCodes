public class Solution 
{
    public char NextGreatestLetter(char[] letters, char target) 
    {
        if(target == 'z') return letters[0];
        
        int left = 0, right = letters.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (letters[mid] > target)
            {
                if(mid - 1 < 0) return letters[0];
                
                if(letters[mid-1] <= target) return letters[mid];
                
                right = mid - 1;
            }
            else left = mid + 1;
        }
        
        return letters[0];
    }
}