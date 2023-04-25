using System;

class KnapsackProblem
{
    static int maxWeight;
    static int[] weights;
    static int[] values;
    static int numItems;

    static int FindMaxValue(int currentItem, int currentWeight, int currentValue)
    {
        if (currentWeight > maxWeight) // base case: weight limit exceeded
        {
            return 0;
        }

        if (currentItem == numItems) // base case: all items considered
        {
            return currentValue;
        }

        int maxValue = currentValue;

        // Try including the current item
        int includeValue = FindMaxValue(currentItem + 1, currentWeight + weights[currentItem], currentValue + values[currentItem]);
        maxValue = Math.Max(maxValue, includeValue);

        // Try excluding the current item
        int excludeValue = FindMaxValue(currentItem + 1, currentWeight, currentValue);
        maxValue = Math.Max(maxValue, excludeValue);

        return maxValue;
    }


    

    static void Main()
    {
        maxWeight = 10;
        weights = new int[] { 135, 3, 478, 113, 192, 32, 115, 188, 91, 72, 131, 271, 126, 104, 486, 373, 25, 74, 490, 93, 231, 248, 259, 149, 216, 179, 424, 432, 381, 428, 167, 470, 261, 237, 372, 152, 101, 254, 80, 346, 182, 119, 368, 96, 336, 321, 297, 262, 99, 292};
        values = new int[] { 230, 485, 200, 30, 340, 34, 35, 490, 481, 439, 61, 291, 144, 395, 469, 460, 83, 196, 349, 17, 373, 463, 346, 46, 391, 238, 74, 57, 198, 251, 362, 466, 24, 176, 445, 43, 41, 449, 430, 470, 179, 100, 385, 421, 44, 428, 443, 167, 329, 263 };
        numItems = weights.Length;
        double[] bfsTimes = new double[20];
        double[] dfsTimes = new double[20];
int maxValue = 0;
for (int i = 0; i < 20; ++i) {
   var watch = System.Diagnostics.Stopwatch.StartNew();
           
         maxValue = FindMaxValue(0, 0, 0);
         watch.Stop();
         dfsTimes[i] = watch.Elapsed.TotalMilliseconds;
         
}
        Console.WriteLine("Maximum value that can be obtained = " + maxValue);
        
        for (int i = 0; i < 20; ++i) {
   var watch = System.Diagnostics.Stopwatch.StartNew();
           
        bfs.start();
         watch.Stop();
         bfsTimes[i] = watch.Elapsed.TotalMilliseconds;
         
}

getBfsAvgTime(bfsTimes);
getDfsAvgTime(dfsTimes);
    }


     public static void getBfsAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage BFS time in ms: " + average);


        }
          public static void getDfsAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage DFS time in ms: " + average);


        }


}