public class QuickSort {
    public int Partition(int[] numsToSort, int low, int high) {

        //The first step of quick sort is to pick a pivot

        int pivot = numsToSort[high];
        int lowIndex = (low - 1);

        //checks if number is less than pivot, if so reassigns accordingly

        for (int i = low; i < high; i++) {
            
            if (numsToSort[i] <= pivot) {
                lowIndex++;

                int tempLow = numsToSort[lowIndex];
                numsToSort[lowIndex] = numsToSort[i];
                numsToSort[i] = tempLow;
            }
        }

        int temp1 = numsToSort[lowIndex + 1];
        numsToSort[lowIndex + 1] = numsToSort[high];
        numsToSort[high] = temp1;

        return lowIndex + 1;

    }

    public void sort(int[] numsToSort, int low, int high) {
        if (low < high) {
            int partitionIndex = Partition(numsToSort, low, high);

            sort(numsToSort, low, partitionIndex - 1);
            sort(numsToSort, partitionIndex + 1, high);
        }
    }


}