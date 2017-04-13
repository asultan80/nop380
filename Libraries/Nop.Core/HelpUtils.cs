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

        public static int CurrentVendorId
        {
            get
            {
                return VendorLite.GetVendorIdFromContext(SiteContext.GetProperty(ContextKeyNames.CurrentVendor));
            }
        }

        public static string CurrentVendorName
        {
            get
            {
                return VendorLite.GetVendorNameFromContext(SiteContext.GetProperty(ContextKeyNames.CurrentVendor));
            }
        }

        public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
        {
            var cnt = new Dictionary<T, int>();
            foreach (T s in list1)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]++;
                }
                else
                {
                    cnt.Add(s, 1);
                }
            }
            foreach (T s in list2)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]--;
                }
                else
                {
                    return false;
                }
            }
            return cnt.Values.All(c => c == 0);
        }
    }
}
