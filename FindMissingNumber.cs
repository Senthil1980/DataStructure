using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class FindMissingNumber
    {

        public int search(int[] ar, int size)
        {
            int a = 0;
            /*int a = 0, b = size - 1;
            int mid = 0;
            while ((b - a) > 1)
            {
                mid = (a + b) / 2;
                if ((ar[a] - a) != (ar[mid] - mid))
                {
                    b = mid;
                }
                else if ((ar[b] - b) != (ar[mid] - mid))
                {
                    a = mid;
                }
            }
            return (ar[mid] + 1);*/
            Array.Sort(ar);
            int MinVal = ar.Min();
            int MaxVal = ar.Max();
            var x = Enumerable.Range(MinVal, MaxVal).Except(ar);
            foreach(int b in x)
            {
                a = b;
                
            }
            return a;
        }

        // Driver Code 
        public void Mainmethod()
        {
            int[] ar = { 1, 2, 3, 4, 5, 8 };
            int size = ar.Length;
            search(ar, size);
        } 
    }
}
