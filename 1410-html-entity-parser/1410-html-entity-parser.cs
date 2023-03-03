public class Solution
{
    public string EntityParser(string text) =>
        text.Replace("&quot;", "\"").Replace("&apos;", "'").Replace("&gt;", ">").Replace("&lt;", "<").Replace("&frasl;", "/").Replace("&amp;", "&");
}