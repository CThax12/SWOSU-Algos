using System;
public class sorting {
    static int[] nums = new int[5000];

    public static void Main(String[] args)
    {
        Random rand = new Random();
     double[] bsTimes = new double[20];
     double[] lsTimes = new double[20];
     double[] bubbleSortTimes = new double[20];
     double[] msTimes = new double[20];
     for (int i = 0; i < 5000; ++i) {
        
        int singleValue = rand.Next(5000);
        nums[i] = singleValue;
     }


      for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            bsCalculate(nums);
            watch.Stop();
            
            bubbleSortTimes[i] = watch.Elapsed.TotalMilliseconds;

            }


            for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            msCalculate(nums);
            watch.Stop();
            msTimes[i] = watch.Elapsed.TotalMilliseconds;
            }
            getdcAvgTime(msTimes);
            getdpAvgTime(bubbleSortTimes);   
            
    
        nums[10] = 250;
        Array.Sort(nums);
      for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            lsCalculate(nums, 250);
            watch.Stop();
            
            lsTimes[i] = watch.Elapsed.TotalMilliseconds;

            }


            for (int i = 0; i < 20; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            binarySearchCalculate(nums, 250);
            watch.Stop();
            bsTimes[i] = watch.Elapsed.TotalMilliseconds;
            }
            getBsAvgTime(bsTimes);
            getLsAvgTime(lsTimes);   
            
            Console.WriteLine();
    
    }
  


 public static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            //Console.WriteLine("Linear search found element at index: " + i);

            return i; // Found the target element at index i
        }
    }
    return -1; // Target element not found in array
}


public static int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (arr[mid] == target)
        {
            //Console.WriteLine("Binary search found element at index: " + mid);
            return mid; // Target element found at index mid
        }
        else if (arr[mid] < target)
        {
            left = mid + 1; // Target is in the right half of the array
        }
        else
        {
            right = mid - 1; // Target is in the left half of the array
        }
    }
    return -1; // Target element not found in array
}

public static void BubbleSort(int[] nums)
{
    int[] arr = nums;
    int n = arr.Length;
    bool swapped;

    do
    {
        swapped = false;
        for (int i = 1; i < n; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
                swapped = true;
            }
        }
        n--;
    
    } while (swapped);
    
}

public static void MergeSort(int[] nums, int left, int right)
{
    int[] arr = nums;
    if (left < right)
    {
        int middle = (left + right) / 2;
        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);
        Merge(arr, left, middle, right);
    }
}

public static void Merge(int[] arr, int left, int middle, int right)
{
    int[] temp = new int[right - left + 1];
    int i = left, j = middle + 1, k = 0;

    while (i <= middle && j <= right)
    {
        if (arr[i] < arr[j])
        {
            temp[k] = arr[i];
            k++;
            i++;
        }
        else
        {
            temp[k] = arr[j];
            k++;
            j++;
        }
    }

    while (i <= middle)
    {
        temp[k] = arr[i];
        k++;
        i++;
    }

    while (j <= right)
    {
        temp[k] = arr[j];
        k++;
        j++;
    }

    for (i = left; i <= right; i++)
    {
        arr[i] = temp[i - left];
    }
}



        


           


    

    public static void lsCalculate(int[] nums, int target) {
        LinearSearch(nums, target);
            

        }

        public static void binarySearchCalculate(int[] nums, int target) {
        BinarySearch(nums, target);

        }

         public static void bsCalculate(int[] nums) {
        BubbleSort(nums);
            

        }

         public static void msCalculate(int[] nums) {
        MergeSort(nums, 0, nums.Length-1);
            

        }


        public static void getdcAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Merge Sort time in ms: " + average);


        }

        public static void getdpAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];

            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Bubble Sort time in ms: " + average);

        }

        public static void getBsAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Binary Search time in ms: " + average);


        }
        public static void getLsAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }
            sum -= times[0];
            double average = sum/19;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Linear Search time in ms: " + average);


        }

        
}