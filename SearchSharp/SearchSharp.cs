using System;

namespace SearchSharp
{
    public static class SearchSharp<T>
    {
        /// <summary>
        /// Returns the index of the given item. Index includes the number 0, for example the 1st items index is 0, and so on.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int Linear(T item, T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (item.Equals(data[i]))
                {
                    return i;
                }
            }

            throw new Exception("That item is not in the dataset.");
        }

        /// <summary>
        /// Returns the index of the given item using the Binary Search algorithm.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="data"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Binary(int item, int[] data, int min, int max)
        {
            if (min >= max)
            {
                throw new Exception("That item is not in the dataset.");
            }

            int mid = (max + min) / 2;

            if (data[mid] < item)
            {
                return Binary(item, data, mid + 1, max);
            }
            else if (item < data[mid])
            {
                return Binary(item, data, min, mid - 1);
            }
            else
            {
                return mid;
            }
        }

        /// <summary>
        /// Performs a Jump Search on the given array, and returns the index of the item to search for.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="data"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        public static int Jump(int item, int[] data, int block)
        {
            int goBack = 0;

            for (int i = 0; i < data.Length; i += block)
            {
                if (item < data[i])
                {
                    goBack = i - block;
                    break;
                }
            }

            for (int j = goBack; j < data.Length; j++)
            {
                if (item == data[j])
                {
                    return j;
                }
            }

            throw new Exception("That item is not in the dataset.");
        }
    }
}
