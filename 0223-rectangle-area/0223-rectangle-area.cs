public class Solution 
{
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) 
    {
        int first = (C-A)*(D-B);
        int second = (G-E)*(H-F);
        if(A>=G || E>=C || F>=D || B>=H) return first+second; // No overleap
        
        //Calculate the overleap
        int CG = (C<G) ? C : G;
        int DH = (D<H) ? D : H;
        int AE = (A>E) ? A : E;
        int BF = (B>F) ? B : F;
        int common = (CG-AE)*(DH-BF);
        return first+second-common;
    }
}