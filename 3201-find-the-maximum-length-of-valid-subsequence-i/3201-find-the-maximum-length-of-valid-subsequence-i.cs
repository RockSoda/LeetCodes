public class Solution 
{
    public int MaximumLength(int[] nums) 
    {
        bool IsEven(int num) => (num & 1) == 0;

        int GetNonAlt(bool isEvenSeq)
        {
            var len = 0;

            foreach(var num in nums)
            {
                if(IsEven(num) && isEvenSeq) len++;
                else if(!IsEven(num) && !isEvenSeq) len++;
            }

            return len;
        }

        int FindFirstIdx(bool isStartWithEven)
        {
            var firstIdx = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if(IsEven(nums[i]) && isStartWithEven)
                {
                    firstIdx = i;
                    break;
                }
                else if(!IsEven(nums[i]) && !isStartWithEven)
                {
                    firstIdx = i;
                    break;
                }
            }
            return firstIdx;
        }
        
        int GetAlt(bool isStartWithEven)
        {
            var firstIdx = FindFirstIdx(isStartWithEven);

            if(firstIdx == -1) return 0;

            int len = 1;
            bool isPrevEven = isStartWithEven;
            for(int i = firstIdx+1; i < nums.Length; i++)
            {
                var isCurrEven = IsEven(nums[i]);
                bool isAlt = (isPrevEven && !isCurrEven) || (!isPrevEven && isCurrEven);

                if(!isAlt) continue;
                
                len++;
                isPrevEven = isCurrEven;
            }
            return len;
        }

        return Math.Max(Math.Max(GetNonAlt(true), GetNonAlt(false)), Math.Max(GetAlt(true), GetAlt(false)));
    }
}