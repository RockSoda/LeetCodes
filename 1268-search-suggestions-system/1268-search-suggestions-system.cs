public class Solution 
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) 
    {
        Array.Sort(products);
        var output = new List<IList<string>>();
        var search = new StringBuilder();
        foreach(var c in searchWord)
        {
            search.Append(c);
            output.Add(products.Where(p => p.StartsWith(search.ToString())).Take(3).ToList());
        }
        
        return output;
    }
}