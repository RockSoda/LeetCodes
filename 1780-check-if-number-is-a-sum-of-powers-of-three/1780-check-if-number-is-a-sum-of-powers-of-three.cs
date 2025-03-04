public class Solution 
{
    public string ToTrenary(int value) 
    {
      if (value == 0) return "";

      StringBuilder Sb = new StringBuilder();
      Boolean signed = false;

      if (value < 0) 
      {
        signed = true; 
        value = -value;
      }

      while (value > 0) 
      {
        Sb.Insert(0, value % 3);
        value /= 3;
      }

      if (signed) Sb.Insert(0, '-');

      return Sb.ToString();
    }
    
    public bool CheckPowersOfThree(int n) 
    {
        var ternary = ToTrenary(n);
        
        foreach(char c in ternary) if(c == '2') return false;
        
        return true;
    }
}