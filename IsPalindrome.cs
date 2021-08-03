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
            //best case is when str has only one character
            if (str.Length <= 1)
            {
                return true;
            }
            else
            {   
                //if the first character is not equal to the last character 
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }
                else
                {
                    return recursiveCheck(str.Substring(1, str.Length - 2));
                }
            }
        }

        public static bool pointersCheck(string str)
        {
            int fp = 0;

            int lp = str.Length - 1;

            while(fp <= lp)
            {
                if(str[fp] != str[lp])
                {
                    return false;
                }
                else
                {
                    fp++;
                    lp--;
                }
            }

            return true;
        }

        public static bool reverseArray(string str)
        {
            
            string reverse = string.Empty;

            //decrementing loop from the last char to the first
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            //compare if reversed is the same as the original string
            if (str == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       

    }
}
