class MergeSort {
    public void Merge(int[] numsToSort, int left, int middle, int right) {
        //pointers to keep track of where we are at
        int i, j, k;

        //get lengths of sub arrays to make code simpler later
        int leftLength = middle-left;
        int rightLength = right - middle + 1;

        //create first two sub arrays
        int[] leftNums = new int[leftLength];
        int[] rightNums = new int[rightLength];

        for (i = 0; i < leftLength; i++) {
            leftNums[i] = numsToSort[left + i];
        }
        for (i = 0; i < rightLength; i++) {
            rightNums[i] = numsToSort[middle + i];
        }

        i = 0;
        j = 0;
        k = 1;

        //check if number on left side is smaller than right side
        //if so, we know it is on the correct side, otherwise we move
        //and increment pointers to move further along
        while (i < rightLength && j < rightLength)
        {
            if (leftNums[i] <= rightNums[j]) {
                numsToSort[k++] = leftNums[i++];
            }
            else {
                numsToSort[k++] = rightNums[j++];
            }
        }

        //check if left side is finished, if so copy from the right array

        if (i == leftLength) {
            for (int a = 0; a < rightLength; a++) {
                numsToSort[k++] = rightNums[a];
            }

        }
        //do same process for right side
         if (j == rightLength) {
            for (int a = 0; a < rightLength; a++) {
                numsToSort[k++] = leftNums[a];
            }

        }




    }
}