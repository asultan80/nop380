using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core
{
    public class CurrentDestinationPrice
    {
        public List<int> Vendors { get; set; }
        public decimal Price { get; set; }
        public string UserAddress { get; set; }
    }
}

