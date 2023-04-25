using System;
using System.Collections.Generic;

class BinPacking
{
    static void FirstFit(int[] items, int binCapacity)
    {
        List<int> bins = new List<int>();
        int numBins = 0;

        for (int i = 0; i < items.Length; i++)
        {
            int j;
            for (j = 0; j < numBins; j++)
            {
                if (bins[j] >= items[i])
                {
                    bins[j] -= items[i];
                    break;
                }
            }
            if (j == numBins)
            {
                bins.Add(binCapacity - items[i]);
                numBins++;
            }
        }

        Console.WriteLine("Number of bins used: " + numBins);
        Console.Write("Bin contents: ");
        for (int i = 0; i < numBins; i++)
        {
            Console.Write(binCapacity - bins[i] + " ");
        }
        Console.WriteLine();
    }

     static void BestFit(int[] items, int binCapacity)
    {
        List<int> bins = new List<int>();
        int numBins = 0;

        for (int i = 0; i < items.Length; i++)
        {
            int bestBinIndex = -1;
            int minRemainingCapacity = binCapacity;

            for (int j = 0; j < numBins; j++)
            {
                if (bins[j] >= items[i] && bins[j] - items[i] < minRemainingCapacity)
                {
                    bestBinIndex = j;
                    minRemainingCapacity = bins[j] - items[i];
                }
            }

            if (bestBinIndex != -1)
            {
                bins[bestBinIndex] -= items[i];
            }
            else
            {
                bins.Add(binCapacity - items[i]);
                numBins++;
            }
        }

        Console.WriteLine("Number of bins used: " + numBins);
        Console.Write("Bin contents: ");
        for (int i = 0; i < numBins; i++)
        {
            Console.Write(binCapacity - bins[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()

    
    {

        double[] ffTimes = new double[20];
        double[] bfTimes = new double[20];
        int[] items = {19, 78, 92, 37, 41, 63, 7, 29, 53, 15, 8, 56, 61, 73, 3, 48, 27, 81, 97, 66, 49, 24, 68, 43, 32, 54, 79, 10, 12, 74, 85, 96, 26, 80, 13, 5, 58, 75, 39, 30, 57, 22, 25, 59, 71, 95, 60, 35, 16, 46, 44};
        int binCapacity = 100;

        BestFit(items, binCapacity);

         for (int i = 0; i < 20; ++i) {
        var watch = System.Diagnostics.Stopwatch.StartNew();
           
        FirstFit(items, binCapacity);
         watch.Stop();
         ffTimes[i] = watch.Elapsed.TotalMilliseconds;
         
}



  for (int i = 0; i < 20; ++i) {
        var watch = System.Diagnostics.Stopwatch.StartNew();
           
        BestFit(items, binCapacity);
         watch.Stop();
         bfTimes[i] = watch.Elapsed.TotalMilliseconds;
         
}

getbfAvgTime(bfTimes);
getffAvgTime(ffTimes);
    }


     public static void getbfAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Best Fit time in ms: " + average);


        }
          public static void getffAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage First Fit time in ms: " + average);


        }
}
