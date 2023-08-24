public class Solution 
{
    public IList<string> FullJustify(string[] words, int maxWidth) 
    {
        var output = new List<string>();
        var strList = new List<string>();
        var currLen = 0;
        
        int[] GetNumOfSpaces()
        {
            var numOfSpace = maxWidth - strList.Sum(str => str.Length);
            if(strList.Count == 1) return new int[]{ numOfSpace };
            
            int remainder = numOfSpace % (strList.Count - 1);
            
            int[] spaces = new int[strList.Count - 1];
            Array.Fill(spaces, numOfSpace / (strList.Count - 1));
            for(int i = 0; i < remainder; i++) spaces[i]++;
            
            return spaces;
        }
        
        void AddToList(bool isLastLine = false)
        {
            var numOfSpaces = GetNumOfSpaces();
            var sb = new StringBuilder();
            for(int i = 0; i < strList.Count; i++)
            {
                sb.Append(strList[i]);
                if(i < numOfSpaces.Length) sb.Append(' ', numOfSpaces[i]);
            }
            output.Add(sb.ToString());
            strList.Clear();
            currLen = 0;
        }
        
        for(int i = 0; i < words.Length; i++)
        {
            currLen += words[i].Length;
            if(currLen < maxWidth)
            {
                strList.Add(words[i]);
                currLen++;
                continue;
            }
            
            if(currLen > maxWidth) i--;
            else if(currLen == maxWidth) strList.Add(words[i]);
            
            AddToList();
        }
        
        if(strList.Count > 0)
        {
            var sb = new StringBuilder();
            foreach(var str in strList)
            {
                sb.Append(str);
                if(sb.Length < maxWidth) sb.Append(' ');
            }
            
            sb.Append(' ', maxWidth - sb.Length);
            output.Add(sb.ToString());
        }
        
        return output;
    }
}