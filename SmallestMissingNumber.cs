using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class SmallestMissingNumber
    {
        
        public  int findFirstMissing(int[] array,int start, int end)
        {
            //-1, -2, -3

            Array.Sort(array);            
               if (start > end)
                {
                    return end + 1;
                }

                if (start != array[start])
                {
                    return start;
                }

                int mid = (start + end) / 2;

                // Left half has all elements from 0 to mid 
                if (array[mid] == mid)
                {
                    return findFirstMissing(array, mid + 1, end);
                }
                return findFirstMissing(array, start, mid);

        }
        public int max_element(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
            }
            return max;
        } 
    }
}
