using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace StudentPerformanceWebsite
{
    static class Validation
    {
        public static bool ValidationGrade(byte x)
        {
            bool res = false;
            if (x > 0 && x < 6) res = true;
            return res;
        }

        public static bool ValidationEmail(string x)
        {
            bool res = false;
            Regex r = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$");
            if(x !="")
            {
                if(r.IsMatch(x))
                {
                    res = true;
                }
            }         
            
            return res;
        }

        public static bool ValidationName(string x)
        {
            bool res = true;
            if (x != "")
            {
                foreach (char i in x)
                {
                    if (char.IsDigit(i)) res = false;
                }
            }
            else res = false;
            return res;
        }

        public static bool IsNotNull(string x)
        {
            bool res = true;
            if (x == "") res = false;
            return res;
        }
    }
}