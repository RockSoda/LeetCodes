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
                bool isAligned = (IsEven(num) && isEvenSeq) || (!IsEven(num) && !isEvenSeq);
                
                if(!isAligned) continue;

                len++;
            }

            return len;
        }

        int FindFirstIdx(bool isStartWithEven)
        {
            var firstIdx = -1;

            for(int i = 0; i < nums.Length; i++)
            {
                bool isAligned = (IsEven(nums[i]) && isStartWithEven) || (!IsEven(nums[i]) && !isStartWithEven);

                if(!isAligned) continue;

                firstIdx = i;
                break;
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