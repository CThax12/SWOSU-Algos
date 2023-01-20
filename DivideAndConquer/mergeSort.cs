public class MergeSort {
    
    public int[] mSort(int[] numsToSort, int left, int right) {
        if (left < right) {
            int middle = left + (right - left) / 2;

            //sort right side
            mSort(numsToSort, left, middle);

            //sort left side
            mSort(numsToSort, middle + 1, right);

            //merge together
            Merge(numsToSort, left, middle, right);

        }

        return numsToSort;
        
    }
    
    public void Merge(int[] numsToSort, int left, int middle, int right) {
        //pointers to keep track of where we are at
        int i, j, k;

        //get lengths of sub arrays to make code simpler later
        int leftLength = middle-left + 1;
        int rightLength = right - middle;

        //create first two sub arrays
        int[] leftNums = new int[leftLength];
        int[] rightNums = new int[rightLength];

        for (i = 0; i < leftLength; ++i) {
            leftNums[i] = numsToSort[left + i];
        }
        for (j = 0; j < rightLength; ++j) {
            rightNums[j] = numsToSort[middle + 1 + j];
        }

        i = 0;
        j = 0;
        k = left;

        //check if number on left side is smaller than right side
        //if so, we know it is on the correct side, otherwise we move
        //and increment pointers to move further along
        while (i < leftLength && j < rightLength)
        {
            if (leftNums[i] <= rightNums[j]) {
                numsToSort[k++] = leftNums[i++];
            }
            else {
                numsToSort[k++] = rightNums[j++];
            }
        }

        //check if left side is finished, if so copy from the right array

        while (i < leftLength) {
            numsToSort[k++] = leftNums[i++];
        }
        while (j < rightLength) {
            numsToSort[k++] = rightNums[j++];
        }

        }




    }