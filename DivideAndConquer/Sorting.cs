    using System;

    class Sorting {

    public static void Main(string[] args) { 
        //Randomly generate list of numbers to sort
            int[] numsToSort = getListOfNums();
            int numsLength = numsToSort.Length;
            double[] times = new double[10];

            for (int i = 0; i < 10; ++i) {
            numsToSort = getListOfNums();
            numsLength = numsToSort.Length;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            qSort(numsToSort, 0, numsLength - 1);
            watch.Stop();
            times[i] = watch.Elapsed.TotalMilliseconds;
            }

            getQSAvgTime(times);

        }

        public static int[] getListOfNums() {
            Random rand = new Random();
            int[] numsToSort = new int[10000];
            for (int i = 0; i < numsToSort.Length; ++i) {
                numsToSort[i] = rand.Next(10000);
            }

            return numsToSort;

        }

        public static void qSort(int[] numsToSort, int low, int length) {
            QuickSort qs = new QuickSort();
            qs.sort(numsToSort, 0, length);


            foreach (var num in numsToSort)
            {
                Console.Write(num.ToString() + ", ");
            }

        }

        public static void getQSAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }

            double average = sum/10;
            Console.WriteLine("\n\nAverage Quick Sort time in ms: " + average);

        }
    

    }
