using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nop.Core
{
    public class HelpUtils
    {
        public static string FormatPhoneNumber(string s)
        {
            var numbersOnly = Regex.Replace(s, @"[^\dnN]", String.Empty);
            try
            {
                return string.Format("({0}) {1}-{2}", s.Substring(0, 3), s.Substring(3, 3), s.Substring(6, 4));
            }            
            catch(Exception)
            {
                return s;
            }
        }
    }
}
