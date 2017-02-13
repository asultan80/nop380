using System.Collections.Generic;
using Nop.Web.Framework.Mvc;
using Nop.Web.Models.Catalog;

namespace Nop.Web.Models.Common
{
    public partial class VendorsSliderModel : BaseNopModel
    {
        public List<VendorModel> VendorsList { get; set; }
    }
}