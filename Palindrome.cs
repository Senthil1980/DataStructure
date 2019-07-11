using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class Palindrome
    {

        public  String Palindrome1(String str)
        {

            #region Method1
            //Char[] a = str.ToCharArray();          


            //String result = string.Empty;
            // int b = str.Length / 2;
            /*int j = str.Length - 1; 
            for (int i = 0; i < str.Length/2; i++)
            {              
                    //total length / 2
                    //4 3 2 1 0 str[lenght-1] //decrement
                    //0 1 2 3 4 -  char[i] //increment             

                    if ( str[i] != str[j])
                    {
                        return null;
                    }                    
               
                j--;
            }

            return str;*/
                #endregion


            #region Method2
            var reversed = Enumerable.Range(0, str.Length / 2).Select(i => str[i] == str[(str.Length-1) - i]).All(b => b);
            if (reversed == false)
            {
                return null;
            }
            return str;
            #endregion


            
        }
    }
}
