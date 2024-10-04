public class Solution 
{
    public long DividePlayers(int[] skill) 
    {
        Array.Sort(skill);
        int left = 0, right = skill.Length-1;
        long point = -1, chemistry = 0;
        while (left <= right)
        {
            if (point == -1) point = skill[left] + skill[right];
            else if(skill[left] + skill[right] != point) return -1;

            chemistry += skill[left++] * skill[right--];
        }
        return chemistry;
    }
}