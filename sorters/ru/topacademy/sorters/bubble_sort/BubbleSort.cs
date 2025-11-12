namespace ru.topacademy.sorters.bubble_sort
{
    public static class BubbleSort
    {
        public static void Bubble_Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) 
            { 
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
