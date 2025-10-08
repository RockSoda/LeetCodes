public class Solution 
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) 
    {
        int GetNumOfStrongPotion(int spell)
        {
            int left = 0, right = potions.Length;
            
            double threshold = (double)success / (double)spell;

            while(left < right)
            {
                int mid = left + (right - left) / 2;

                if(threshold > potions[mid]) left = mid + 1;
                else right = mid;
            }

            return potions.Length - left;
        }

        Array.Sort(potions);
        var output = new int[spells.Length];
        for(int i = 0; i < spells.Length; i++)
        {
            output[i] = GetNumOfStrongPotion(spells[i]);
        }
        return output;
    }
}