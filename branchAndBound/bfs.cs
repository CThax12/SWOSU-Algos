using System;
using System.Collections.Generic;

class bfs
{
    static int maxWeight;
    static int[] weights;
    static int[] values;
    static int numItems;

    class KnapsackState
    {
        public int itemIndex;
        public int weight;
        public int value;

        public KnapsackState(int itemIndex, int weight, int value)
        {
            this.itemIndex = itemIndex;
            this.weight = weight;
            this.value = value;
        }
    }

    static int FindMaxValue()
    {
        int maxValue = 0;
        Queue<KnapsackState> queue = new Queue<KnapsackState>();
        queue.Enqueue(new KnapsackState(0, 0, 0));

        while (queue.Count > 0)
        {
            KnapsackState currentState = queue.Dequeue();

            if (currentState.weight > maxWeight) // weight limit exceeded
            {
                continue;
            }

            if (currentState.itemIndex == numItems) // all items considered
            {
                maxValue = Math.Max(maxValue, currentState.value);
                continue;
            }

            // Try including the current item
            queue.Enqueue(new KnapsackState(currentState.itemIndex + 1, currentState.weight + weights[currentState.itemIndex], currentState.value + values[currentState.itemIndex]));

            // Try excluding the current item
            queue.Enqueue(new KnapsackState(currentState.itemIndex + 1, currentState.weight, currentState.value));
        }

        return maxValue;
    }

    public static void start() {
        run();
    }

    static void run()
    {
        maxWeight = 10;
        weights = new int[] { 135, 3, 478, 113, 192, 32, 115, 188, 91, 72, 131, 271, 126, 104, 486, 373, 25, 74, 490, 93, 231, 248, 259, 149, 216, 179, 424, 432, 381, 428, 167, 470, 261, 237, 372, 152, 101, 254, 80, 346, 182, 119, 368, 96, 336, 321, 297, 262, 99, 292};
        values = new int[] { 230, 485, 200, 30, 340, 34, 35, 490, 481, 439, 61, 291, 144, 395, 469, 460, 83, 196, 349, 17, 373, 463, 346, 46, 391, 238, 74, 57, 198, 251, 362, 466, 24, 176, 445, 43, 41, 449, 430, 470, 179, 100, 385, 421, 44, 428, 443, 167, 329, 263 };

        numItems = weights.Length;

        int maxValue = FindMaxValue();
        Console.WriteLine("Maximum value that can be obtained = " + maxValue);
    }



}
