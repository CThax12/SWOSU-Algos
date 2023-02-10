using System;
 
public class DP {
 
    int DPbinomial(int n, int k)
    {
        int[] results = new int[k + 1];
 
        results[0] = 1;
 
        for (int i = 1; i <= n; i++) {

            for (int j = Math.Min(i, k); j > 0; j--)
                results[j] = results[j] + results[j - 1];
        }
        return results[k];
    }
 
    public void test()
    {
        int n = 50, k = 7;
        Console.WriteLine("Value of C(" + n + ", " + k + ") using DP is " + DPbinomial(n, k));
    }
}