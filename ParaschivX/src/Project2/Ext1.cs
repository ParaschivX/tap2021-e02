using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static  class Ext1
    {
        public static bool isValidSequence(string s) {
            if (s.Length == 1000) {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != 'A' || s[i] != 'C' || s[i] != 'G' || s[i] != 'T' ) return false;
                }
            }
            else return false;
            return true;
        }
    }
}
