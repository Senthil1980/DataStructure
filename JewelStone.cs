using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class JewelStone
    {
        public int NumJewelsInStones(string J, string S)
        {
            HashSet<char> Jset = new HashSet<char>();
            int ans = 0;
            foreach (char j in J)
            {
                Jset.Add(j);
            }
            foreach (char s in S)
            {
                if (Jset.Contains(s) == true)
                {
                    ans++;
                }
            }

            return ans;
        } 
    }
}
