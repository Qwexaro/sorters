namespace ru.topacademy.sorters.shell_sort
{
    public static class ShellSort
    {
        public static int[] Shell_Sort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = Convert.ToInt32(Math.Floor((double)n / 2)); gap > 0; gap = Convert.ToInt32(Math.Floor((double)gap / 2)))
            {

                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }

            return arr;
        }
    }
}
