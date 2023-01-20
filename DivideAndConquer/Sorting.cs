    using System;

    class Sorting {

    public static void Main(string[] args) { 
        //Randomly generate list of numbers to sort
            int[] numsToSort = getListOfNums();
            int numsLength = numsToSort.Length;

            qSort(numsToSort, 0, numsLength - 1);


        }

        public static int[] getListOfNums() {
            Random rand = new Random();
            int[] numsToSort = new int[100];
            for (int i = 0; i < numsToSort.Length; ++i) {
                numsToSort[i] = rand.Next(100);
            }

            return numsToSort;

        }

        public static void qSort(int[] numsToSort, int low, int length) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            QuickSort qs = new QuickSort();
            qs.sort(numsToSort, 0, length);
            watch.Stop();
            foreach (var num in numsToSort)
            {
                Console.Write(num.ToString() + ", ");
            }

            Console.WriteLine("\n Quick sort took: " + watch.ElapsedMilliseconds);
        }
    

    }
