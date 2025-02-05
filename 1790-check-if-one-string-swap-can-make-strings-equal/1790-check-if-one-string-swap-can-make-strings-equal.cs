public class Solution 
{
    public bool AreAlmostEqual(string s1, string s2) 
    {
        if(s1.Length != s2.Length) return false;

        char c1 = '-', c2 = '-';
        bool isDiffFound = false, isSwapped = false;

        for(int i = 0; i < s1.Length; i++)
        {
            char curr1 = s1[i], curr2 = s2[i];
            if(curr1 == curr2) continue;

            if(!isDiffFound)
            {
                isDiffFound = true;
                c1 = curr1;
                c2 = curr2;
            }
            else
            {
                if(isSwapped || c1 != curr2 || c2 != curr1) return false;
                isSwapped = true;
            }
        }

        return isDiffFound == isSwapped;
    }
}