namespace _10_24_DelegateBubbleSort
{
    class DelegateBubbleSort
    {
        public delegate bool Comparator(int element, int element2);

        public static void SortArray(int[] array, Comparator Compare)
        {
            for (int pass = 0; pass < array.Length; pass++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (Compare(array[i], array[i + 1]))
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int firstElement, ref int secondElement)
        {
            int hold = firstElement;
            firstElement = secondElement;
            secondElement = hold;
        }
    }
}
