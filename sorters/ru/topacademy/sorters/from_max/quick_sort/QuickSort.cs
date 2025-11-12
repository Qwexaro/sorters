namespace ru.topacademy.sorters.from_max.quick_sort
{
    public static class QuickSort
    {
        public static List<int> Quick_Sort(List<int> list)
        {

            if (list.Count <= 1)
            {
                return list;
            }


            int pivot = list.Last();


            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();


            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < pivot)
                {
                    leftList.Add(list[i]);
                }
                else
                {
                    rightList.Add(list[i]);
                }
            }


            List<int> sortedLeft = Quick_Sort(leftList);
            List<int> sortedRight = Quick_Sort(rightList);


            sortedLeft.Add(pivot);
            sortedLeft.AddRange(sortedRight);

            return sortedLeft;
        }
    }
}
