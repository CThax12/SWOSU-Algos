using System ;
 
public class backtrack {
     
   
    static int max(int a, int b)
    {
        return (a > b) ? a : b;
    }
 
   
    static void printknapSack(int W, int []wt,
                            int []val, int n)
    {
        int i, w;
        int [,]K = new int[n + 1,W + 1];
 
        for (i = 0; i <= n; i++) {
            for (w = 0; w <= W; w++) {
                if (i == 0 || w == 0)
                    K[i,w] = 0;
                else if (wt[i - 1] <= w)
                    K[i,w] = Math.Max(val[i - 1] +
                            K[i - 1,w - wt[i - 1]], K[i - 1,w]);
                else
                    K[i,w] = K[i - 1,w];
            }
        }
 
 
        int results = K[n,W];
        Console.WriteLine(results);
 
        w = W;
        for (i = n; i > 0 && results > 0; i--) {
 
          
            if (results == K[i - 1,w])
                continue;
            else {
 
                Console.Write(wt[i - 1] + " ");
 
                results = results - val[i - 1];
                w = w - wt[i - 1];
            }
        }
    }
 
    public static void testBacktrack(int[] weights, int[] vals)
    {

        int W = 50;
        int n = vals.Length;
 
        printknapSack(W, weights, vals, n);
    }
}
 
