public class Solution 
{
    public IList<string> WordSubsets(string[] words1, string[] words2) 
    {
        int[][] GetWordMap(string[] words)
        {
            var size = words.Length;
            var wordsMap = new int[size][];
            for(int i = 0; i < size; i++)
            {
                wordsMap[i] = new int[26];
                foreach(var c in words[i]) wordsMap[i][c-'a']++;
            }
            return wordsMap;
        }

        bool IsSubset(int[] a, int[] b)
        {
            for(int i = 0; i < 26; i++)
            {
                if(a[i] < b[i]) return false;
            }

            return true;
        }

        var words1Map = GetWordMap(words1);
        var words2Map = GetWordMap(words2.ToHashSet().ToArray());

        var output = new List<string>();
        for(int i = 0; i < words1.Length; i++)
        {
            bool isBreaked = false;
            foreach(var word2Map in words2Map)
            {
                if(IsSubset(words1Map[i], word2Map)) continue;

                isBreaked = true;
                break;
            }
            if(!isBreaked) output.Add(words1[i]);
        }

        return output;
    }
}