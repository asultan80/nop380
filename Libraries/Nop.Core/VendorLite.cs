using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core
{
    public class VendorLite
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static string GetVendorNameFromContext(object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return (obj as VendorLite).Name;
        }

        public static int GetVendorIdFromContext(object obj)
        {
            if (obj == null)
            {
                return -1;
            }
            return (obj as VendorLite).Id;
        }
    }
}
