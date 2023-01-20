    using System;

    class Sorting {

    public static void Main(string[] args) { 
        //Randomly generate list of numbers to sort
            int[] numsToSort = getListOfNums();
            int numsLength = numsToSort.Length;
            double[] qsTimes = new double[10];
            double[] msTimes = new double[10];

            for (int i = 0; i < 10; ++i) {
            //generate new list of random numbers
            numsToSort = getListOfNums();
            numsLength = numsToSort.Length;

            //time how long quick sort takes
            var watch = System.Diagnostics.Stopwatch.StartNew();
            qSort(numsToSort, 0, numsLength - 1);
            watch.Stop();
            qsTimes[i] = watch.Elapsed.TotalMilliseconds;

            watch.Reset();

            //time how long merge sort takes
            watch = System.Diagnostics.Stopwatch.StartNew();
            mSort(numsToSort, 0, numsLength - 1);
            watch.Stop();
            msTimes[i] = watch.Elapsed.TotalMilliseconds;

            
            }

            getQSAvgTime(qsTimes);
            getMSAvgTime(msTimes);   

        }

        public static int[] getListOfNums() {
            Random rand = new Random();
            int[] numsToSort = new int[10000];
            for (int i = 0; i < numsToSort.Length; ++i) {
                numsToSort[i] = rand.Next(100000);
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

        public static void mSort(int[] numsToSort, int low, int length) {
            MergeSort ms = new MergeSort();
            ms.mSort(numsToSort, 0, length - 1);
            Console.WriteLine("\n");
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
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Quick Sort time in ms: " + average);
            Console.WriteLine("\nLongest Quick Sort time in ms: " + highest);


        }

        public static void getMSAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }

            double average = sum/10;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Merge Sort time in ms: " + average);
            Console.WriteLine("\nLongest Merge Sort time in ms: " + highest);

        }
    

    }
