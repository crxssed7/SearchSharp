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
            // Go through the array
            for (int i = 0; i < data.Length; i++)
            {
                // If the item is found, return the index that it was found at
                if (item.Equals(data[i]))
                {
                    return i;
                }
            }

            // If we reach this part, we know the item does not exist
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
            // If minimum ends up being bigger than the maximum, then we know the item does not exist
            if (min >= max)
            {
                throw new Exception("That item is not in the dataset.");
            }

            // Calculate the midpoint
            int mid = (max + min) / 2;

            if (data[mid] < item)
            {
                // If the middle item is smaller than the item to be found, then call the function again with modded values
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
            // Used for when we need to go back to a certain part of the array
            int goBack = 0;

            // Go through the array, incrementing by the value given in the block arg
            for (int i = 0; i < data.Length; i += block)
            {
                // If the item is less than the current element, then we know we have to go back by a certain amount
                if (item < data[i])
                {
                    goBack = i - block;
                    break;
                }
            }

            // Simple linear search.
            for (int j = goBack; j < data.Length; j++)
            {
                if (item == data[j])
                {
                    return j;
                }
            }

            // If we get here we know the item does not exist
            throw new Exception("That item is not in the dataset.");
        }
    }
}
