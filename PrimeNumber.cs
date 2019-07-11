using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
   public static class PrimeNumber
    {

       public static void getAllPrimes(int[] number)
       {
           for (int i = 0; i < number.Length; i++)
           {
               if (isPrime(number[i]))
               {
                   Console.WriteLine(i);
               }
           }
       }
       public static  bool isPrime(this int number)
       {

           for (int i = 2; i < number; i++)
           {
               if (number % i == 0)
               {
                   return false;
               }
           }

           return true;
       }
      
      
    }
}
