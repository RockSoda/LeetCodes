public class Solution 
{
    public int[] DeckRevealedIncreasing(int[] deck) 
    {
        Array.Sort(deck);
        var que = new Queue<int>();
        for(int i = deck.Length-1; i >= 0; i--)
        {
            var card = deck[i];
            if(que.Count > 0) que.Enqueue(que.Dequeue());
            que.Enqueue(card);
        }
        
        var arr = que.ToArray();
        Array.Reverse(arr);
        
        return arr;
    }
}