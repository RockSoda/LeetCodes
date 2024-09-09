/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public int[][] SpiralMatrix(int m, int n, ListNode head) 
    {
        var output = new int[m][];
        for(int idx = 0; idx < output.Length; idx++)
        {
            output[idx] = new int[n];
            Array.Fill(output[idx], -1);
        }
        
        int i = 0, j = 0;
                                            // right, down, left, up
        var movements = new (int, int)[]{ (0, 1), (1, 0), (0, -1), (-1, 0) };
        var curr = 0;
        void CalcIdx()
        {
            (int nextIPadding, int nextJPadding) = movements[curr];
            int nextI = i + nextIPadding;
            int nextJ = j + nextJPadding;
            
            if(nextI < 0 || nextI >= m || nextJ < 0 || nextJ >= n || output[nextI][nextJ] != -1)
            {
                curr = (curr + 1) % 4;
                (nextIPadding, nextJPadding) = movements[curr];
                nextI = i + nextIPadding;
                nextJ = j + nextJPadding;
            }
            i = nextI;
            j = nextJ;
        }

        while(head != null)
        {
            output[i][j] = head.val;
            CalcIdx();
            head = head.next;
        }

        return output;
    }
}