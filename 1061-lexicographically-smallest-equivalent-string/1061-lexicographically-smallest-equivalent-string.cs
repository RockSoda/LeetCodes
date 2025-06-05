public class Solution 
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr) 
    {
        var map = new bool[26][];
        for(int i = 0; i < map.Length; i++)
        {
            map[i] = new bool[26];
            map[i][i] = true;
        }

        var smallestMap = new int[26];

        void LoadSmallestMap()
        {
            var visited = new bool[26];
            int FindSmallest(int key)
            {
                var min = key;
                if(visited[key]) return min;

                visited[key] = true;
                if(smallestMap[key] != 0) return smallestMap[key];

                for(int i = 0; i < map[key].Length; i++)
                {
                    if(!map[key][i]) continue;
                    min = Math.Min(FindSmallest(i), min);
                }
                return min;
            }

            for(int i = 0; i < map.Length; i++)
            {
                smallestMap[i] = FindSmallest(i);
                Array.Fill(visited, false);
            }
        }

        for(int i = 0; i < s1.Length; i++)
        {
            var key1 = s1[i]-'a';
            var key2 = s2[i]-'a';

            map[key1][key2] = true;
            map[key2][key1] = true;
        }

        LoadSmallestMap();

        var sb = new StringBuilder();
        foreach(var c in baseStr)
        {
            var key = c-'a';
            char smallestChar = (char)(smallestMap[key]+'a');
            sb.Append(smallestChar);
        }
        return sb.ToString();
    }
}