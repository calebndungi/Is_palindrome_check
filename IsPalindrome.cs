using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Palindrome_Check
{
    public class IsPalindrome
    {
        public static bool recursiveCheck(string str)
        {


            return true;
        }

        public static bool pointersCheck(string str)
        {

            return true;
        }

        public static bool reverseArray(string str)
        {
            
            return true;
        }
        public static bool StartsWithUpper(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

    }
}
