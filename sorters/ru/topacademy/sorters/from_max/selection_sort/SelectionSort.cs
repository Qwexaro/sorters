namespace ru.topacademy.sorters.from_max.selection_sort
{
    public static class SelectionSort
    {
        public static List<int> Selection_Sort(List<int> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }


                if (minIndex != i)
                {
                    (list[i], list[minIndex]) = (list[minIndex], list[i]);
                }
            }

            return list;
        }
    }
}
