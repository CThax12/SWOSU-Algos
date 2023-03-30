using System;
public class Program {
    public class item {
        public int value;
        public int weight;
 
        public item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }
    static int knapSack(int maxWeight, int[] wt, int[] val, int n)
    {
        int[] dp = new int[maxWeight + 1];
 
        for (int i = 1; i < n + 1; i++) {
            for (int w = maxWeight; w >= 0; w--) {
 
                if (wt[i - 1] <= w)
 
                    dp[w]
                        = Math.Max(dp[w], dp[w - wt[i - 1]]
                                              + val[i - 1]);
            }
        }
        return dp[maxWeight];
    }
    public static item[] items = new item[50];
    static int[] vals = new int[50];
    static int[] weights = new int[50];
    static int maxWeight = 50;
    static int n = vals.Length;
    static double[] dcTimes = new double[20];
    static double[] dpTimes = new double[20];
    public static void Main(String[] args)
    {
        Random rand = new Random();

     for (int i = 0; i < 50; ++i) {
        
        int singleValue = rand.Next(500);
        int singleWeight = rand.Next(500);
        items[i] = new item(singleValue, singleWeight);
     }

     for (int i = 0; i < 50; ++i) {
        weights[i] = items[i].weight;
        vals[i] = items[i].value;
     }


 
        


        //time how long Divide and Conquer takes
            for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            dcCalculate();
            watch.Stop();
            
            dcTimes[i] = watch.Elapsed.TotalMilliseconds;

            }


            //time how long Dynamic Programming takes
            for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            dpCalculate();
            watch.Stop();
            dpTimes[i] = watch.Elapsed.TotalMilliseconds;
            }
            getdcAvgTime(dcTimes);
            getdpAvgTime(dpTimes);   
            btCalculate();
            



    }

    public static void dcCalculate() {
            //greedy.test(weights, vals);
            backtrack.testBacktrack(weights, vals);

        }

        public static void dpCalculate() {
            Console.WriteLine(knapSack(maxWeight, weights, vals, n));

        }
    public static void btCalculate() {

    }

        public static void getdcAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage backtrack time in ms: " + average);


        }

        public static void getdpAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];

            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Dynamic Programming time in ms: " + average);

        }

        
}