namespace ru.topacademy.sorters.insertion_sort
{
    public static class InsertionSort
    {
        public static int[] Insertion_Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }

            return arr;
        }
    }
}