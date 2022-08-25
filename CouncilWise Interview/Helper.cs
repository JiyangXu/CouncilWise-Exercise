using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilWise
{
    public static class Helper
    {
        const decimal TaxRate = 0.1m;

        public static decimal CurrencyRound(this decimal value)
        {
            return Math.Round(value, 2);
        }

        public static bool CheckPalindrome(string str)
        {
            if (str == null)
                return false;
            string res = "";
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i];
            }
            if (res == str)
            {
                return true;
            }
            return false;
            
        }
    }
}
