using System;
using System.Collections;
 
public class greedy {
 

   class item {
       public int value;
       public int weight;

       public item(int value, int weight)
       {
           this.value = value;
           this.weight = weight;
       }
   }
 
 //compare items
    class cprCompare : IComparer {
        public int Compare(Object x, Object y)
        {
            item item1 = (item)x;
            item item2 = (item)y;
            double cpr1 = (double)item1.value
                          / (double)item1.weight;
            double cpr2 = (double)item2.value
                          / (double)item2.weight;
 
            if (cpr1 < cpr2)
                return 1;
 
            return cpr1 > cpr2 ? -1 : 0;
        }
    }
 
    static double FracKnapSack(item[] items, int w)
    {
 
        cprCompare cmp = new cprCompare();
        Array.Sort(items, cmp);
 

        double totalVal = 0f;
        int currentWeight = 0;
 
        foreach(item i in items)
        {
            float remaining = w - currentWeight;
 
            if (i.weight <= remaining) {
                totalVal += (double)i.value;
                currentWeight += i.weight;
            }
 
            else {
                if (remaining == 0)
                    break;
 
                double fraction
                    = remaining / (double)i.weight;
                totalVal += fraction * (double)i.value;
                currentWeight += (int)(fraction * (double)i.weight);
            }
        }
        return totalVal;
    }
 
    public static void test(int[] weights, int[] values)
    {
        item[] arr = new item[50];

        for (int i = 0; i < 50; ++i) {
            arr[i] = new item(weights[i], values[i]);
        }
 
        Console.WriteLine(FracKnapSack(arr, 50));

    }
}