using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class FindDuplicateNumbers
    {

        public void MainMethod()
        {
            int[] arr = {1,0,3,4,3};
            int arr_size = arr.Length;
            int missing = FindDuplicate(arr);

        }
        public IList<int> findduplicatenumber1(int[] arr, int arVal)        
        {
            HashSet<int> _cs1 = new HashSet<int>();
            int x = 0;
            if(arVal == 0)
            {
                return new int[0];
            }
            else if (arVal == 1)
            {
                return arr;
            }
            else
            {    
                
                for (int i = 0; i < arVal; i++)
                {
                    x = arr[i];
                    for(int j=i+1; j < arVal; j++ )
                    {
                        if (x == arr[j] && _cs1.Contains(arr[j]) == false)
                        {
                            _cs1.Add(arr[j]);
                        }
                    }
                }
                arr = (_cs1.ToArray());
                return arr;
            }
        }
        public int findduplicatenumber(int[] arr, int arVal)
        {
            HashSet<int> _cs1 = new HashSet<int>();
            int x = 0;
            if (arVal == 0)
            {
                return 0;
            }
            else if (arVal == 1)
            {
                return arr[0];
            }
            else
            {

                for (int i = 0; i < arVal; i++)
                {
                    x = arr[i];
                    for (int j = i + 1; j < arVal; j++)
                    {
                        if (x == arr[j] && _cs1.Contains(arr[j]) == false)
                        {
                            _cs1.Add(arr[j]);
                            arVal = arr[j];
                        }
                    }
                }
                return arVal;
            }
        }
        public int FindDuplicate(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != i + 1)
                {
                    if (nums[i] != nums[nums[i] - 1])
                        Swap(nums, i, nums[i] - 1);
                    else // we have found the duplicate
                        return nums[i];
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
