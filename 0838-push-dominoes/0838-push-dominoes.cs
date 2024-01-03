public class Solution 
{
    public string PushDominoes(string dominoes) 
    {
        var charAry = dominoes.ToCharArray();
        
        int GetNextL(int idx)
        {
            for(int i = idx; i < dominoes.Length; i++)
                if(dominoes[i] == 'L') return i;
            
            return -1;
        }
        
        int GetMidIdx(int l, int r) 
        {
            if((l - r)%2 != 0) return -1;
            
            return r + (l - r) / 2;
        }
        
        void Move(int start, int end, char dir)
        {
            for(int i = start; i <= end; i++) charAry[i] = dir;
        }
        
        bool CanMoveLeft(int prevL, int idx)
        {
            for(int i = prevL; i <= idx; i++)
                if(charAry[i] == 'R') return false;
            
            return true;
        }
        
        bool IsLastR(int idx)
        {
            for(int i = idx+1; i < charAry.Length; i++)
            {
                if(charAry[i] == 'L') return true;
                else if(charAry[i] == 'R') 
                {
                    Move(idx, i, 'R');
                    return false;
                }
            }
            
            return true;
        }
        
        bool isFirstL = true;
        int prevL = -1;
        for(int i = 0; i < charAry.Length-1; i++)
        {
            if(charAry[i] == 'L')
            {
                if(isFirstL)
                {
                    isFirstL = false;
                    Move(0, i, 'L');
                }
                else if(CanMoveLeft(prevL, i)) Move(prevL, i, 'L');
                
                prevL = i;
                continue;
            }
            
            if(charAry[i] != 'R' || !IsLastR(i)) continue;
            
            isFirstL = false;
            var nextL = GetNextL(i);
            if(nextL == -1)
            {
                Move(i, charAry.Length-1, 'R');
                break;
            }
                
            var mid = GetMidIdx(nextL, i);
                
            if(mid == -1)
            {
                var offset = (nextL-i-1)/2;
                Move(i, i+offset, 'R');
                Move(i+offset+1, nextL, 'L');
            }
            else
            {
                Move(i, mid-1, 'R');
                Move(mid+1, nextL, 'L');
            }
                
            prevL = nextL;
            i = nextL;
        }
        
        if(charAry.Last() == 'L')
        {
            var idx = -1;
            for(int i = charAry.Length-2; i >= 0; i--)
            {
                if(charAry[i] == '.') continue;
                
                if(charAry[i] == 'L') idx = i+1;
                break;
            }
            
            if(idx != -1) Move(idx, charAry.Length-1, 'L');
            else if(isFirstL) Move(0, charAry.Length-1, 'L');
        }
        
        return new string(charAry);
    }
}