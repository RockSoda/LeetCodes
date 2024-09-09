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
        char dir = 'r';

        void CalcIdx()
        {
            switch(dir)
            {
                case 'r':
                {
                    j++;
                    if(j >= n || output[i][j] != -1)
                    {
                        dir = 'd';
                        j--;
                        i++;
                    }
                    break;
                }
                case 'l':
                {
                    j--;
                    if(j < 0 || output[i][j] != -1)
                    {
                        dir = 'u';
                        j++;
                        i--;
                    }
                    break;
                }
                case 'u':
                {
                    i--;
                    if(i < 0 || output[i][j] != -1)
                    {
                        dir = 'r';
                        i++;
                        j++;
                    }
                    break;
                }
                case 'd':
                {
                    i++;
                    if(i >= m || output[i][j] != -1)
                    {
                        dir = 'l';
                        i--;
                        j--;
                    }
                    break;
                }
                default:
                    break;
            }
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