using System;
 
public class Recursion {
 

     int recursiveBC(int n, int k)
    {
         if (k > n) {
            return 0;
         }
        if (k == 0 || k == n){
            return 1;
        }
        
         return recursiveBC(n - 1, k - 1) + recursiveBC(n - 1, k);
    }
 
     public void test()
    {
        int n = 50;
        int k = 7;
        Console.Write("Value of C(" + n + "," + k + ") using DC is " + recursiveBC(n, k));

        DP dp = new DP();
        dp.test();
    }
}
