using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class FindAllMissingNumbers
    {

        public void MainMethod()
        {
            //int[] arr = {  2, 2, 4,  1,  1, 3 };
            int[] arr = { 4, 3, 2, 7, 9, 2, 3, 1 };
            //int[] arr = {};
            //int[] arr = { 0 };
             //int[] arr = {1};
           // int[] arr = {1,1};
            //int[] arr = {1,1,2,2};
            int arr_size = arr.Length;
            IList<int> missing = FindDisappearedNumbers(arr);

        }
        /*public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> _IL;
            if (nums.Length == 0)
            {
                return new int[0];
            }
            else if (nums.Length == 1)
            {
                if (nums[0] == 1)
                {
                    _IL = new int[1];
                    _IL[0] = 2;
                    return _IL;
                }
            }
            else
            {
                HashSet<int> _hs = new HashSet<int>(nums);
                HashSet<int> _cs = new HashSet<int>();
                int MaxVal = nums.Max();
                if (MaxVal == 1)
                {
                    _IL = new int[1];
                    _IL[0] = 2;
                    return _IL;
                }
                else
                {
                    for (int i = 1; i <= nums.Length; i++)
                    {
                        if (_hs.Contains(i) == false)
                        {
                            _cs.Add(i);
                        }
                    }
                    _IL = new int[_cs.Count];
                    _IL = _cs.ToList();
                    return _IL;
                }
            }
            return nums;
        }*/
        //runtime 348ms faster than 23.85% and memory usage: 46MB less than 9.62%
       /* public IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> _cs = new HashSet<int>(nums);
            if (nums.Length == 0)
            {
                return new int[0];
            }
            else if (nums.Length == 1 && nums[0] == 0)
            {
                return new int[1] { 1 };
            }
            else
            {
                int x = nums.Length;
                for (int i = 0; i <= x; i++)
                {
                    if (i > 0 && _cs.Contains(i) == false)
                    {
                        _cs.Add(i);
                    }
                    else
                    {
                        _cs.Remove(i);
                    }
                }
                nums = (_cs.ToArray());
                return nums;
            }
        }*/
        //runtime 348ms faster than 23.85% and memory usage: 46MB less than 9.62%
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var temp = new int[nums.Length];
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                temp[nums[i] - 1]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (temp[i] == 0)
                    result.Add(i + 1);
            }
            return result;
          
        }
      
    }
}
