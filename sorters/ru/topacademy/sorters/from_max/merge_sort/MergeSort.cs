namespace ru.topacademy.sorters.from_max.merge_sort
{
    public static class MergeSort
    {
        public static List<int> mergeSort(List<int> list)
        {
            // Базовый случай: массив из одного элемента уже отсортирован
            if (list.Count <= 1) return list;

            // Делим массив пополам
            int mid = Convert.ToInt32(Math.Floor((double)list.Count / 2));
            var left = list.GetRange(0, mid);
            var right = list.GetRange(mid, list.Count - mid);

            // Рекурсивно сортируем обе половины
            return merge(mergeSort(left), mergeSort(right));
        }

        public static List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new();
            int i = 0;
            int j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            // Добавляем оставшиеся элементы
            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }

    }
}
