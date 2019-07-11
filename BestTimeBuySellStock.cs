using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class BestTimeBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int _MaxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > _MaxProfit)
                        _MaxProfit = profit;
                }
            }
            return _MaxProfit;

        }
    }
}
