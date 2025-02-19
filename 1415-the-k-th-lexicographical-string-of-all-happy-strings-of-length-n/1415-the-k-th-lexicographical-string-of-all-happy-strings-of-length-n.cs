public class Solution 
{
    public string GetHappyString(int n, int k) 
    {
        var letters = new string[]{ "a", "b", "c" };
        var happyList = new List<string>();
        
        void LoadList(string str)
        {
            if (str.Length >= n) 
            {
                happyList.Add(str);
                return;
            }

            foreach(string letter in letters)
            {
                if(str.Length > 0 && str.Last() == letter[0]) continue;

                LoadList(str+letter);
            }
        }

        LoadList(string.Empty);

        return happyList.Count >= k ? happyList[k-1] : string.Empty;
    }
}