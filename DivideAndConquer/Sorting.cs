    class Sorting {

    public static void Main(string[] args) { 
            int[] numsToSort = getListOfNums();
        }

        public static int[] getListOfNums() {
            Random rand = new Random();
            int[] numsToSort = new int[100];
            for (int i = 0; i < numsToSort.Length; ++i) {
                numsToSort[i] = rand.Next(100);
            }

            return numsToSort;

        }

    }
