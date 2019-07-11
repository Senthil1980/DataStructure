using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
   public class SmallestPositiveIntegerMissingNumber
    {

       public void MainMethod()
       {
           int[] arr = {0,2,2,4,0,1,0,1,3};
           int arr_size = arr.Length;
           int missing = findMissing(arr, arr_size); 

       }
       public int findMissing(int[] arr, int arVal)
       {
           int x = 1;         
           if (arVal == 1)
           {
               if(arr[0] == 1)
               {
                   x = 2;
               }
               else
               {
                   return x;
               }
           }
           else
           {
               HashSet<int> _hashSet = new HashSet<int>(arr);
               for (int i = 0; i < _hashSet.Count; i++)
               {                  
                   if(arr[i] > 0)
                   {
                       if(_hashSet.Contains(x) == false)
                       {
                           return x;                         
                          
                       }
                       x++;
                   }                   
               }
               if (x > 0 && _hashSet.Contains(x) == true)
               {
                   x += 1;
               }
           }
          
           return x;
       }
       
    }
}
