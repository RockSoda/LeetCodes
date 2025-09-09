public class Solution 
{
    public bool CanThreePartsEqualSum(int[] arr) 
    {
        bool CanBeSplit(int start, int right)
        {
            int left = 0;
            for(int i = start; i < arr.Length-1; i++)
            {
                left += arr[i];
                right -= arr[i];
                if(left == right) return true;
            }
            return false;
        }

        var firstPiece = 0;
        var twiceThePiece = arr.Sum();
        for(int i = 0; i < arr.Length-1; i++)
        {
            firstPiece += arr[i];
            twiceThePiece -= arr[i];
            if(twiceThePiece != firstPiece*2) continue;

            if(CanBeSplit(i+1, twiceThePiece)) return true;
        }
        return false;
    }
}