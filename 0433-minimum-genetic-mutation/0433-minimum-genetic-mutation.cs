public class Solution 
{
    private bool IsOneDiff(string str1, string str2)
    {
        bool isOneDiff = false;
        for(int i = 0; i < str1.Length; i++)
        {
            if(str1[i] != str2[i])
            {
                if(isOneDiff) return false;
                else isOneDiff = true;
            }
        }
        
        return isOneDiff;
    }
    
    private int Recurse(string curr, string end, HashSet<string> bank)
    {
        if(curr.Equals(end)) return 0;
        
        var dnaList = new List<string>();
        foreach(var dna in bank)
        {
            if(IsOneDiff(dna, curr)) dnaList.Add(dna);
        }
        
        var tmpBank = new HashSet<string>(bank);
        tmpBank.Remove(curr);
        int ans = 100000;
        foreach(var dna in dnaList)
        {
            ans = Math.Min(Recurse(dna, end, tmpBank)+1, ans);
        }
        
        return ans;
    }
    
    public int MinMutation(string start, string end, string[] bank) 
    {
        var bankSet = bank.ToHashSet();
        
        if(!bankSet.Contains(end)) return -1;
        
        if(bank.Length == 1)
        {
            if(IsOneDiff(start, bank[0])) return 1;
            else return -1;
        }
        
        int ans = Recurse(start, end, bankSet);
        
        return ans >= 100000 ? -1 : ans;
    }
}